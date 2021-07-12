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
            this.Text_AccountValue = new System.Windows.Forms.Label();
            this.Text_Balance = new System.Windows.Forms.Label();
            this.OutputText_Balance = new System.Windows.Forms.Label();
            this.Text_CurrencyBalance = new System.Windows.Forms.Label();
            this.ComboBox_CurrencyForBalance = new System.Windows.Forms.ComboBox();
            this.Text_Transactions = new System.Windows.Forms.Label();
            this.Text_SumOfTransaction = new System.Windows.Forms.Label();
            this.TextBox_SumOfTransaction = new System.Windows.Forms.TextBox();
            this.ComboBox_CurrencyForTransaction = new System.Windows.Forms.ComboBox();
            this.Text_CurrencyTransaction = new System.Windows.Forms.Label();
            this.Button_Write = new System.Windows.Forms.Button();
            this.Button_WithDraw = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Text_AccountValue
            // 
            this.Text_AccountValue.AutoSize = true;
            this.Text_AccountValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text_AccountValue.Location = new System.Drawing.Point(194, 9);
            this.Text_AccountValue.Name = "Text_AccountValue";
            this.Text_AccountValue.Size = new System.Drawing.Size(121, 17);
            this.Text_AccountValue.TabIndex = 0;
            this.Text_AccountValue.Text = "Состояние счета";
            this.Text_AccountValue.Click += new System.EventHandler(this.Text_AccountValue_Click);
            // 
            // Text_Balance
            // 
            this.Text_Balance.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Text_Balance.AutoSize = true;
            this.Text_Balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text_Balance.Location = new System.Drawing.Point(91, 63);
            this.Text_Balance.Name = "Text_Balance";
            this.Text_Balance.Size = new System.Drawing.Size(60, 17);
            this.Text_Balance.TabIndex = 1;
            this.Text_Balance.Text = "Баланс:";
            this.Text_Balance.Click += new System.EventHandler(this.Text_Balance_Click);
            // 
            // OutputText_Balance
            // 
            this.OutputText_Balance.AutoSize = true;
            this.OutputText_Balance.Location = new System.Drawing.Point(194, 63);
            this.OutputText_Balance.Name = "OutputText_Balance";
            this.OutputText_Balance.Size = new System.Drawing.Size(37, 17);
            this.OutputText_Balance.TabIndex = 2;
            this.OutputText_Balance.Text = "---.--";
            this.OutputText_Balance.Click += new System.EventHandler(this.OutputText_Balance_Click);
            // 
            // Text_CurrencyBalance
            // 
            this.Text_CurrencyBalance.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Text_CurrencyBalance.AutoSize = true;
            this.Text_CurrencyBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text_CurrencyBalance.Location = new System.Drawing.Point(91, 101);
            this.Text_CurrencyBalance.Name = "Text_CurrencyBalance";
            this.Text_CurrencyBalance.Size = new System.Drawing.Size(62, 17);
            this.Text_CurrencyBalance.TabIndex = 3;
            this.Text_CurrencyBalance.Text = "Валюта:";
            this.Text_CurrencyBalance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Text_CurrencyBalance.Click += new System.EventHandler(this.Text_CurrencyBalance_Click);
            // 
            // ComboBox_CurrencyForBalance
            // 
            this.ComboBox_CurrencyForBalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBox_CurrencyForBalance.FormattingEnabled = true;
            this.ComboBox_CurrencyForBalance.Location = new System.Drawing.Point(197, 101);
            this.ComboBox_CurrencyForBalance.Name = "ComboBox_CurrencyForBalance";
            this.ComboBox_CurrencyForBalance.Size = new System.Drawing.Size(121, 24);
            this.ComboBox_CurrencyForBalance.TabIndex = 4;
            this.ComboBox_CurrencyForBalance.SelectedIndexChanged += new System.EventHandler(this.ComboBox_CurrencyForBalance_SelectedIndexChanged);
            // 
            // Text_Transactions
            // 
            this.Text_Transactions.AutoSize = true;
            this.Text_Transactions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text_Transactions.Location = new System.Drawing.Point(197, 203);
            this.Text_Transactions.Name = "Text_Transactions";
            this.Text_Transactions.Size = new System.Drawing.Size(87, 17);
            this.Text_Transactions.TabIndex = 5;
            this.Text_Transactions.Text = "Транзакции";
            this.Text_Transactions.Click += new System.EventHandler(this.Text_Transactions_Click);
            // 
            // Text_SumOfTransaction
            // 
            this.Text_SumOfTransaction.AutoSize = true;
            this.Text_SumOfTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text_SumOfTransaction.Location = new System.Drawing.Point(94, 249);
            this.Text_SumOfTransaction.Name = "Text_SumOfTransaction";
            this.Text_SumOfTransaction.Size = new System.Drawing.Size(54, 17);
            this.Text_SumOfTransaction.TabIndex = 6;
            this.Text_SumOfTransaction.Text = "Сумма:";
            this.Text_SumOfTransaction.Click += new System.EventHandler(this.Text_SumOfTransaction_Click);
            // 
            // TextBox_SumOfTransaction
            // 
            this.TextBox_SumOfTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox_SumOfTransaction.Location = new System.Drawing.Point(197, 249);
            this.TextBox_SumOfTransaction.Name = "TextBox_SumOfTransaction";
            this.TextBox_SumOfTransaction.Size = new System.Drawing.Size(100, 23);
            this.TextBox_SumOfTransaction.TabIndex = 7;
            this.TextBox_SumOfTransaction.Text = "---.--";
            this.TextBox_SumOfTransaction.TextChanged += new System.EventHandler(this.TextBox_SumOfTransaction_TextChanged);
            // 
            // ComboBox_CurrencyForTransaction
            // 
            this.ComboBox_CurrencyForTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBox_CurrencyForTransaction.FormattingEnabled = true;
            this.ComboBox_CurrencyForTransaction.Location = new System.Drawing.Point(197, 291);
            this.ComboBox_CurrencyForTransaction.Name = "ComboBox_CurrencyForTransaction";
            this.ComboBox_CurrencyForTransaction.Size = new System.Drawing.Size(121, 24);
            this.ComboBox_CurrencyForTransaction.TabIndex = 9;
            this.ComboBox_CurrencyForTransaction.SelectedIndexChanged += new System.EventHandler(this.ComboBox_CurrencyForTransaction_SelectedIndexChanged);
            // 
            // Text_CurrencyTransaction
            // 
            this.Text_CurrencyTransaction.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Text_CurrencyTransaction.AutoSize = true;
            this.Text_CurrencyTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text_CurrencyTransaction.Location = new System.Drawing.Point(91, 291);
            this.Text_CurrencyTransaction.Name = "Text_CurrencyTransaction";
            this.Text_CurrencyTransaction.Size = new System.Drawing.Size(62, 17);
            this.Text_CurrencyTransaction.TabIndex = 8;
            this.Text_CurrencyTransaction.Text = "Валюта:";
            this.Text_CurrencyTransaction.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Text_CurrencyTransaction.Click += new System.EventHandler(this.Text_CurrencyTransaction_Click);
            // 
            // Button_Write
            // 
            this.Button_Write.Location = new System.Drawing.Point(55, 354);
            this.Button_Write.Name = "Button_Write";
            this.Button_Write.Size = new System.Drawing.Size(93, 23);
            this.Button_Write.TabIndex = 10;
            this.Button_Write.Text = "Зачислить";
            this.Button_Write.UseVisualStyleBackColor = true;
            this.Button_Write.Click += new System.EventHandler(this.Button_Write_Click);
            // 
            // Button_WithDraw
            // 
            this.Button_WithDraw.Location = new System.Drawing.Point(197, 354);
            this.Button_WithDraw.Name = "Button_WithDraw";
            this.Button_WithDraw.Size = new System.Drawing.Size(80, 23);
            this.Button_WithDraw.TabIndex = 11;
            this.Button_WithDraw.Text = "Снять";
            this.Button_WithDraw.UseVisualStyleBackColor = true;
            this.Button_WithDraw.Click += new System.EventHandler(this.Button_WithDraw_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 450);
            this.Controls.Add(this.Button_WithDraw);
            this.Controls.Add(this.Button_Write);
            this.Controls.Add(this.ComboBox_CurrencyForTransaction);
            this.Controls.Add(this.Text_CurrencyTransaction);
            this.Controls.Add(this.TextBox_SumOfTransaction);
            this.Controls.Add(this.Text_SumOfTransaction);
            this.Controls.Add(this.Text_Transactions);
            this.Controls.Add(this.ComboBox_CurrencyForBalance);
            this.Controls.Add(this.Text_CurrencyBalance);
            this.Controls.Add(this.OutputText_Balance);
            this.Controls.Add(this.Text_Balance);
            this.Controls.Add(this.Text_AccountValue);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Text_AccountValue;
        private System.Windows.Forms.Label Text_Balance;
        private System.Windows.Forms.Label OutputText_Balance;
        private System.Windows.Forms.Label Text_CurrencyBalance;
        private System.Windows.Forms.ComboBox ComboBox_CurrencyForBalance;
        private System.Windows.Forms.Label Text_Transactions;
        private System.Windows.Forms.Label Text_SumOfTransaction;
        private System.Windows.Forms.TextBox TextBox_SumOfTransaction;
        private System.Windows.Forms.ComboBox ComboBox_CurrencyForTransaction;
        private System.Windows.Forms.Label Text_CurrencyTransaction;
        private System.Windows.Forms.Button Button_Write;
        private System.Windows.Forms.Button Button_WithDraw;
    }
}

