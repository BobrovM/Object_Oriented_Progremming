namespace KrestikiNolixi3X3
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
            this.PlayerXScore = new System.Windows.Forms.Label();
            this.Player0Score = new System.Windows.Forms.Label();
            this.PlayerXScoreCount = new System.Windows.Forms.Label();
            this.Player0ScoreCounter = new System.Windows.Forms.Label();
            this.ButtonNewMatch = new System.Windows.Forms.Button();
            this.ButtonReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PlayerXScore
            // 
            this.PlayerXScore.AutoSize = true;
            this.PlayerXScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlayerXScore.Location = new System.Drawing.Point(742, 37);
            this.PlayerXScore.Name = "PlayerXScore";
            this.PlayerXScore.Size = new System.Drawing.Size(178, 29);
            this.PlayerXScore.TabIndex = 0;
            this.PlayerXScore.Text = "Счет игрока Х";
            this.PlayerXScore.Click += new System.EventHandler(this.PlayerXScore_Click);
            // 
            // Player0Score
            // 
            this.Player0Score.AutoSize = true;
            this.Player0Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Player0Score.Location = new System.Drawing.Point(746, 141);
            this.Player0Score.Name = "Player0Score";
            this.Player0Score.Size = new System.Drawing.Size(174, 29);
            this.Player0Score.TabIndex = 1;
            this.Player0Score.Text = "Счет игрока 0";
            this.Player0Score.Click += new System.EventHandler(this.Player0Score_Click);
            // 
            // PlayerXScoreCount
            // 
            this.PlayerXScoreCount.AutoSize = true;
            this.PlayerXScoreCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlayerXScoreCount.Location = new System.Drawing.Point(811, 79);
            this.PlayerXScoreCount.Name = "PlayerXScoreCount";
            this.PlayerXScoreCount.Size = new System.Drawing.Size(32, 36);
            this.PlayerXScoreCount.TabIndex = 2;
            this.PlayerXScoreCount.Text = "0";
            this.PlayerXScoreCount.Click += new System.EventHandler(this.PlayerXScoreCount_Click);
            // 
            // Player0ScoreCounter
            // 
            this.Player0ScoreCounter.AutoSize = true;
            this.Player0ScoreCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Player0ScoreCounter.Location = new System.Drawing.Point(811, 197);
            this.Player0ScoreCounter.Name = "Player0ScoreCounter";
            this.Player0ScoreCounter.Size = new System.Drawing.Size(32, 36);
            this.Player0ScoreCounter.TabIndex = 3;
            this.Player0ScoreCounter.Text = "0";
            this.Player0ScoreCounter.Click += new System.EventHandler(this.Player0ScoreCounter_Click);
            // 
            // ButtonNewMatch
            // 
            this.ButtonNewMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonNewMatch.Location = new System.Drawing.Point(79, 715);
            this.ButtonNewMatch.Name = "ButtonNewMatch";
            this.ButtonNewMatch.Size = new System.Drawing.Size(170, 75);
            this.ButtonNewMatch.TabIndex = 4;
            this.ButtonNewMatch.Text = "Новый матч";
            this.ButtonNewMatch.UseVisualStyleBackColor = true;
            this.ButtonNewMatch.Click += new System.EventHandler(this.ButtonNewMatch_Click);
            // 
            // ButtonReset
            // 
            this.ButtonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonReset.Location = new System.Drawing.Point(385, 715);
            this.ButtonReset.Name = "ButtonReset";
            this.ButtonReset.Size = new System.Drawing.Size(170, 75);
            this.ButtonReset.TabIndex = 5;
            this.ButtonReset.Text = "Обнулить игру";
            this.ButtonReset.UseVisualStyleBackColor = true;
            this.ButtonReset.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 1033);
            this.Controls.Add(this.ButtonReset);
            this.Controls.Add(this.ButtonNewMatch);
            this.Controls.Add(this.Player0ScoreCounter);
            this.Controls.Add(this.PlayerXScoreCount);
            this.Controls.Add(this.Player0Score);
            this.Controls.Add(this.PlayerXScore);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PlayerXScore;
        private System.Windows.Forms.Label Player0Score;
        private System.Windows.Forms.Label PlayerXScoreCount;
        private System.Windows.Forms.Label Player0ScoreCounter;
        private System.Windows.Forms.Button ButtonNewMatch;
        private System.Windows.Forms.Button ButtonReset;
    }
}

