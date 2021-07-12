
namespace Laba7_8
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
            this.RichTextBox_XML = new System.Windows.Forms.RichTextBox();
            this.RichTextBox_News = new System.Windows.Forms.RichTextBox();
            this.RichTextBox_DataBase = new System.Windows.Forms.RichTextBox();
            this.Button_Read = new System.Windows.Forms.Button();
            this.Button_Write = new System.Windows.Forms.Button();
            this.Button_ReadDB = new System.Windows.Forms.Button();
            this.Label_XMLCode = new System.Windows.Forms.Label();
            this.Label_XMLToText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RichTextBox_XML
            // 
            this.RichTextBox_XML.Location = new System.Drawing.Point(12, 111);
            this.RichTextBox_XML.Name = "RichTextBox_XML";
            this.RichTextBox_XML.ReadOnly = true;
            this.RichTextBox_XML.Size = new System.Drawing.Size(336, 580);
            this.RichTextBox_XML.TabIndex = 0;
            this.RichTextBox_XML.Text = "";
            this.RichTextBox_XML.TextChanged += new System.EventHandler(this.RichTextBox_XML_TextChanged);
            // 
            // RichTextBox_News
            // 
            this.RichTextBox_News.Location = new System.Drawing.Point(371, 111);
            this.RichTextBox_News.Name = "RichTextBox_News";
            this.RichTextBox_News.ReadOnly = true;
            this.RichTextBox_News.Size = new System.Drawing.Size(380, 580);
            this.RichTextBox_News.TabIndex = 1;
            this.RichTextBox_News.Text = "";
            this.RichTextBox_News.TextChanged += new System.EventHandler(this.RichTextBox_News_TextChanged);
            // 
            // RichTextBox_DataBase
            // 
            this.RichTextBox_DataBase.Location = new System.Drawing.Point(774, 111);
            this.RichTextBox_DataBase.Name = "RichTextBox_DataBase";
            this.RichTextBox_DataBase.ReadOnly = true;
            this.RichTextBox_DataBase.Size = new System.Drawing.Size(312, 580);
            this.RichTextBox_DataBase.TabIndex = 2;
            this.RichTextBox_DataBase.Text = "";
            this.RichTextBox_DataBase.TextChanged += new System.EventHandler(this.RichTextBox_DataBase_TextChanged);
            // 
            // Button_Read
            // 
            this.Button_Read.Location = new System.Drawing.Point(135, 12);
            this.Button_Read.Name = "Button_Read";
            this.Button_Read.Size = new System.Drawing.Size(100, 50);
            this.Button_Read.TabIndex = 3;
            this.Button_Read.Text = "Считать RSS файл";
            this.Button_Read.UseVisualStyleBackColor = true;
            this.Button_Read.Click += new System.EventHandler(this.Button_Read_Click);
            // 
            // Button_Write
            // 
            this.Button_Write.Location = new System.Drawing.Point(517, 12);
            this.Button_Write.Name = "Button_Write";
            this.Button_Write.Size = new System.Drawing.Size(100, 50);
            this.Button_Write.TabIndex = 4;
            this.Button_Write.Text = "Записать в базу данных";
            this.Button_Write.UseVisualStyleBackColor = true;
            this.Button_Write.Click += new System.EventHandler(this.Button_Write_Click);
            // 
            // Button_ReadDB
            // 
            this.Button_ReadDB.Location = new System.Drawing.Point(872, 12);
            this.Button_ReadDB.Name = "Button_ReadDB";
            this.Button_ReadDB.Size = new System.Drawing.Size(105, 50);
            this.Button_ReadDB.TabIndex = 5;
            this.Button_ReadDB.Text = "Считать с базы данных";
            this.Button_ReadDB.UseVisualStyleBackColor = true;
            this.Button_ReadDB.Click += new System.EventHandler(this.Button_ReadDB_Click);
            // 
            // Label_XMLCode
            // 
            this.Label_XMLCode.AutoSize = true;
            this.Label_XMLCode.Location = new System.Drawing.Point(151, 88);
            this.Label_XMLCode.Name = "Label_XMLCode";
            this.Label_XMLCode.Size = new System.Drawing.Size(63, 17);
            this.Label_XMLCode.TabIndex = 6;
            this.Label_XMLCode.Text = "XML код";
            this.Label_XMLCode.Click += new System.EventHandler(this.Label_XMLCode_Click);
            // 
            // Label_XMLToText
            // 
            this.Label_XMLToText.AutoSize = true;
            this.Label_XMLToText.Location = new System.Drawing.Point(522, 88);
            this.Label_XMLToText.Name = "Label_XMLToText";
            this.Label_XMLToText.Size = new System.Drawing.Size(95, 17);
            this.Label_XMLToText.TabIndex = 7;
            this.Label_XMLToText.Text = "XML в тексте";
            this.Label_XMLToText.Click += new System.EventHandler(this.Label_XMLToText_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(851, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Текст с базы данных";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 703);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Label_XMLToText);
            this.Controls.Add(this.Label_XMLCode);
            this.Controls.Add(this.Button_ReadDB);
            this.Controls.Add(this.Button_Write);
            this.Controls.Add(this.Button_Read);
            this.Controls.Add(this.RichTextBox_DataBase);
            this.Controls.Add(this.RichTextBox_News);
            this.Controls.Add(this.RichTextBox_XML);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox RichTextBox_XML;
        private System.Windows.Forms.RichTextBox RichTextBox_News;
        private System.Windows.Forms.RichTextBox RichTextBox_DataBase;
        private System.Windows.Forms.Button Button_Read;
        private System.Windows.Forms.Button Button_Write;
        private System.Windows.Forms.Button Button_ReadDB;
        private System.Windows.Forms.Label Label_XMLCode;
        private System.Windows.Forms.Label Label_XMLToText;
        private System.Windows.Forms.Label label1;
    }
}

