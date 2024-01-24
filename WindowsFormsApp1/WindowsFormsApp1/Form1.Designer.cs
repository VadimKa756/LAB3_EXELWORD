namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.order = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.supplier = new System.Windows.Forms.Label();
            this.Buyer = new System.Windows.Forms.Label();
            this.textBoxSupplier = new System.Windows.Forms.TextBox();
            this.textBoxBuyer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.amount = new System.Windows.Forms.Label();
            this.generateButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // order
            // 
            this.order.AutoSize = true;
            this.order.Location = new System.Drawing.Point(747, 15);
            this.order.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(32, 17);
            this.order.TabIndex = 0;
            this.order.Text = "108";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Location = new System.Drawing.Point(707, 46);
            this.date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(72, 17);
            this.date.TabIndex = 1;
            this.date.Text = "12.2.2017";
            // 
            // supplier
            // 
            this.supplier.AutoSize = true;
            this.supplier.Location = new System.Drawing.Point(17, 16);
            this.supplier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.supplier.Name = "supplier";
            this.supplier.Size = new System.Drawing.Size(81, 17);
            this.supplier.TabIndex = 2;
            this.supplier.Text = "Поставщик";
            // 
            // Buyer
            // 
            this.Buyer.AutoSize = true;
            this.Buyer.Location = new System.Drawing.Point(15, 101);
            this.Buyer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Buyer.Name = "Buyer";
            this.Buyer.Size = new System.Drawing.Size(86, 17);
            this.Buyer.TabIndex = 3;
            this.Buyer.Text = "Покупатель";
            // 
            // textBoxSupplier
            // 
            this.textBoxSupplier.Location = new System.Drawing.Point(113, 36);
            this.textBoxSupplier.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxSupplier.Name = "textBoxSupplier";
            this.textBoxSupplier.Size = new System.Drawing.Size(253, 22);
            this.textBoxSupplier.TabIndex = 4;
            // 
            // textBoxBuyer
            // 
            this.textBoxBuyer.Location = new System.Drawing.Point(113, 121);
            this.textBoxBuyer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxBuyer.Name = "textBoxBuyer";
            this.textBoxBuyer.Size = new System.Drawing.Size(253, 22);
            this.textBoxBuyer.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 457);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Итого:";
            // 
            // amount
            // 
            this.amount.AutoSize = true;
            this.amount.Location = new System.Drawing.Point(21, 495);
            this.amount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(0, 17);
            this.amount.TabIndex = 8;
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(343, 457);
            this.generateButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(204, 62);
            this.generateButton.TabIndex = 9;
            this.generateButton.Text = "Сформировать отчёт";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 178);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(436, 256);
            this.dataGridView1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(672, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Заказ №";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxBuyer);
            this.Controls.Add(this.textBoxSupplier);
            this.Controls.Add(this.Buyer);
            this.Controls.Add(this.supplier);
            this.Controls.Add(this.date);
            this.Controls.Add(this.order);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Сформировать накладную";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label order;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label supplier;
        private System.Windows.Forms.Label Buyer;
        private System.Windows.Forms.TextBox textBoxSupplier;
        private System.Windows.Forms.TextBox textBoxBuyer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label amount;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
    }
}

