using System;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using Microsoft.Office.Interop.Excel;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            // Добавление столбцов в DataGridView
            dataGridView1.Columns.Add("Number", "№");
            dataGridView1.Columns.Add("Product", "Товар");
            dataGridView1.Columns.Add("Quantity", "Количество");
            dataGridView1.Columns.Add("Price", "Цена");

            // Установка автоматической ширины столбцов
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            // Создание нового документа Word
            Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
            Document wordDoc = wordApp.Documents.Add();

            // Создание нового документа Excel
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            Workbook excelWorkbook = excelApp.Workbooks.Add();
            Worksheet excelWorksheet = excelWorkbook.Sheets[1];

            try
            {
                // Заполнение шапки документа Word
                wordDoc.Content.Text = "Расходная накладная № " + order.Text + " от " + date.Text + "\n";
                wordDoc.Content.Text += "Поставщик: " + textBoxSupplier.Text + "\nПокупатель: " + textBoxBuyer.Text + "\n";

                // Создание таблицы в документе Word
                Table wordTable = wordDoc.Tables.Add(wordDoc.Paragraphs[wordDoc.Paragraphs.Count].Range, dataGridView1.Rows.Count + 1, 5);

                // Заполнение заголовков таблицы в документе Word
                for (int j = 0; j < 4; j++)
                {
                    wordTable.Cell(1, j + 1).Range.Text = dataGridView1.Columns[j].HeaderText;
                }
                wordTable.Cell(1, 5).Range.Text = "Сумма";

                // Заполнение данных в таблицу Word
                double totalSum = 0; // Общая сумма
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        var value = dataGridView1.Rows[i].Cells[j].Value;
                        wordTable.Cell(i + 2, j + 1).Range.Text = value != null ? value.ToString() : "";
                    }

                    double quantity = Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value);
                    double price = Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value);
                    double sum = quantity * price;

                    totalSum += sum; // Добавление текущей суммы к общей сумме

                    wordTable.Cell(i + 2, 5).Range.Text = sum.ToString();
                }

                // Удаление последней строки в таблице Word
                int lastRow = wordTable.Rows.Count;
                wordTable.Rows[lastRow].Delete();

                // Вставка слова "Итог" и расчета общей суммы после таблицы Word
                wordDoc.Range(wordDoc.Paragraphs[wordDoc.Paragraphs.Count].Range.End - 1).InsertParagraphAfter();
                wordDoc.Paragraphs[wordDoc.Paragraphs.Count].Range.Text = "Итог: " + totalSum.ToString();

                // Заполнение шапки документа Excel
                excelWorksheet.Cells[1, 1] = "Расходная накладная № " + order.Text + " от " + date.Text;
                excelWorksheet.Cells[2, 1] = "Поставщик: " + textBoxSupplier.Text;
                excelWorksheet.Cells[3, 1] = "Покупатель: " + textBoxBuyer.Text;

                // Создание таблицы в документе Excel
                for (int j = 0; j < 4; j++)
                {
                    excelWorksheet.Cells[5, j + 1] = dataGridView1.Columns[j].HeaderText;
                }
                excelWorksheet.Cells[5, 5] = "Сумма";

                // Заполнение шапки документа Excel
                excelWorksheet.Cells[1, 1] = "Расходная накладная № " + order.Text + " от " + date.Text;
                excelWorksheet.Cells[2, 1] = "Поставщик: " + textBoxSupplier.Text;
                excelWorksheet.Cells[3, 1] = "Покупатель: " + textBoxBuyer.Text;

                // Создание таблицы в документе Excel
                for (int j = 0; j < 4; j++)
                {
                    excelWorksheet.Cells[5, j + 1] = dataGridView1.Columns[j].HeaderText;
                }
                excelWorksheet.Cells[5, 5] = "Сумма";

                // Заполнение данных в таблицу Excel
                int excelRowIndex = 6; // Индекс строки в Excel, начиная с 6
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    bool rowHasData = false;

                    for (int j = 0; j < 4; j++)
                    {
                        var value = dataGridView1.Rows[i].Cells[j].Value;
                        excelWorksheet.Cells[excelRowIndex, j + 1] = value != null ? value : "";

                        if (value != null && !string.IsNullOrEmpty(value.ToString()))
                        {
                            rowHasData = true;
                        }
                    }

                    if (rowHasData)
                    {
                        double quantity = Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value);
                        double price = Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value);
                        double sum = quantity * price;

                        excelWorksheet.Cells[excelRowIndex, 5] = sum;
                        excelRowIndex++;
                    }
                }

                // Добавление "Итог" в соседнюю ячейку после таблицы Excel
                excelWorksheet.Cells[excelRowIndex, 1] = "Итог:";
                excelWorksheet.Cells[excelRowIndex, 2] = totalSum;

                
                // Установка черного цвета контура таблицы в Word
                wordTable.Borders.Enable = 1;  // 1 = True
                wordTable.Borders.InsideLineStyle = WdLineStyle.wdLineStyleSingle;
                wordTable.Borders.OutsideLineStyle = WdLineStyle.wdLineStyleSingle;
                wordTable.Borders.OutsideColor = WdColor.wdColorBlack;
                wordTable.Borders.InsideColor = WdColor.wdColorBlack;

                // Установка черного цвета контура таблицы в Excel
                excelWorksheet.Range["A5", "E" + (excelRowIndex - 1)].Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                excelWorksheet.Range["A5", "E" + (excelRowIndex - 1)].Borders.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black);

                // Вывод общей суммы в label "amount"
                amount.Text =  totalSum.ToString("C"); // Форматирование как валюта

                // Сохранение документов
                string wordFilePath = @"C:\Users\429195-5\Desktop\WordDocument.docx";
                string excelFilePath = @"C:\Users\429195-5\Desktop\ExcelDocument.xlsx";

                wordDoc.SaveAs2(wordFilePath);
                excelWorkbook.SaveAs(excelFilePath);
            }
            finally
            {
                // Закрытие Word и Excel
                wordApp.Quit();
                excelApp.Quit();

                // Освобождение ресурсов Word
                System.Runtime.InteropServices.Marshal.ReleaseComObject(wordDoc);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(wordApp);

                // Освобождение ресурсов Excel
                System.Runtime.InteropServices.Marshal.ReleaseComObject(excelWorksheet);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(excelWorkbook);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
            }
        }
    }
}
