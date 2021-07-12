namespace Ur3_Zad1
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
            this.GameName = new System.Windows.Forms.Label();
            this.SignPlayerNumber = new System.Windows.Forms.Label();
            this.PlayerNumber1 = new System.Windows.Forms.TextBox();
            this.PlayerNumber3 = new System.Windows.Forms.TextBox();
            this.PlayerNumber2 = new System.Windows.Forms.TextBox();
            this.SignRange = new System.Windows.Forms.Label();
            this.Player1Range = new System.Windows.Forms.TextBox();
            this.Player3Range = new System.Windows.Forms.TextBox();
            this.Player2Range = new System.Windows.Forms.TextBox();
            this.ButtonTurn = new System.Windows.Forms.Button();
            this.SignScore = new System.Windows.Forms.Label();
            this.Player1Score = new System.Windows.Forms.TextBox();
            this.Player2Score = new System.Windows.Forms.TextBox();
            this.Player3Score = new System.Windows.Forms.TextBox();
            this.RaceCounter = new System.Windows.Forms.TextBox();
            this.SignRaceCount = new System.Windows.Forms.Label();
            this.SignMaxRaces = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GameName
            // 
            this.GameName.AutoSize = true;
            this.GameName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GameName.Location = new System.Drawing.Point(339, 9);
            this.GameName.Name = "GameName";
            this.GameName.Size = new System.Drawing.Size(112, 29);
            this.GameName.TabIndex = 0;
            this.GameName.Text = "СКАЧКИ";
            this.GameName.Click += new System.EventHandler(this.GameName_Click);
            // 
            // SignPlayerNumber
            // 
            this.SignPlayerNumber.AutoSize = true;
            this.SignPlayerNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SignPlayerNumber.ForeColor = System.Drawing.Color.Black;
            this.SignPlayerNumber.Location = new System.Drawing.Point(12, 54);
            this.SignPlayerNumber.Name = "SignPlayerNumber";
            this.SignPlayerNumber.Size = new System.Drawing.Size(169, 24);
            this.SignPlayerNumber.TabIndex = 1;
            this.SignPlayerNumber.Text = "Номер наездника";
            this.SignPlayerNumber.Click += new System.EventHandler(this.SignPlayerNumber_Click);
            // 
            // PlayerNumber1
            // 
            this.PlayerNumber1.Location = new System.Drawing.Point(16, 82);
            this.PlayerNumber1.Name = "PlayerNumber1";
            this.PlayerNumber1.ReadOnly = true;
            this.PlayerNumber1.Size = new System.Drawing.Size(100, 22);
            this.PlayerNumber1.TabIndex = 2;
            this.PlayerNumber1.TextChanged += new System.EventHandler(this.PlayerNumber1_TextChanged);
            // 
            // PlayerNumber3
            // 
            this.PlayerNumber3.Location = new System.Drawing.Point(16, 164);
            this.PlayerNumber3.Name = "PlayerNumber3";
            this.PlayerNumber3.ReadOnly = true;
            this.PlayerNumber3.Size = new System.Drawing.Size(100, 22);
            this.PlayerNumber3.TabIndex = 3;
            this.PlayerNumber3.TextChanged += new System.EventHandler(this.PlayerNumber3_TextChanged);
            // 
            // PlayerNumber2
            // 
            this.PlayerNumber2.Location = new System.Drawing.Point(16, 120);
            this.PlayerNumber2.Name = "PlayerNumber2";
            this.PlayerNumber2.ReadOnly = true;
            this.PlayerNumber2.Size = new System.Drawing.Size(100, 22);
            this.PlayerNumber2.TabIndex = 4;
            this.PlayerNumber2.TextChanged += new System.EventHandler(this.PlayerNumber2_TextChanged);
            // 
            // SignRange
            // 
            this.SignRange.AutoSize = true;
            this.SignRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SignRange.Location = new System.Drawing.Point(203, 54);
            this.SignRange.Name = "SignRange";
            this.SignRange.Size = new System.Drawing.Size(116, 24);
            this.SignRange.TabIndex = 5;
            this.SignRange.Text = "Расстояние";
            this.SignRange.Click += new System.EventHandler(this.SignRange_Click);
            // 
            // Player1Range
            // 
            this.Player1Range.Location = new System.Drawing.Point(207, 82);
            this.Player1Range.Name = "Player1Range";
            this.Player1Range.ReadOnly = true;
            this.Player1Range.Size = new System.Drawing.Size(100, 22);
            this.Player1Range.TabIndex = 6;
            this.Player1Range.TextChanged += new System.EventHandler(this.Player1Range_TextChanged);
            // 
            // Player3Range
            // 
            this.Player3Range.Location = new System.Drawing.Point(207, 164);
            this.Player3Range.Name = "Player3Range";
            this.Player3Range.ReadOnly = true;
            this.Player3Range.Size = new System.Drawing.Size(100, 22);
            this.Player3Range.TabIndex = 7;
            this.Player3Range.TextChanged += new System.EventHandler(this.Player3Range_TextChanged);
            // 
            // Player2Range
            // 
            this.Player2Range.Location = new System.Drawing.Point(207, 120);
            this.Player2Range.Name = "Player2Range";
            this.Player2Range.ReadOnly = true;
            this.Player2Range.Size = new System.Drawing.Size(100, 22);
            this.Player2Range.TabIndex = 8;
            this.Player2Range.TextChanged += new System.EventHandler(this.Player2Range_TextChanged);
            // 
            // ButtonTurn
            // 
            this.ButtonTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonTurn.Location = new System.Drawing.Point(325, 350);
            this.ButtonTurn.Name = "ButtonTurn";
            this.ButtonTurn.Size = new System.Drawing.Size(143, 77);
            this.ButtonTurn.TabIndex = 9;
            this.ButtonTurn.Text = "Следующий ход";
            this.ButtonTurn.UseVisualStyleBackColor = true;
            this.ButtonTurn.Click += new System.EventHandler(this.ButtonTurn_Click);
            // 
            // SignScore
            // 
            this.SignScore.AutoSize = true;
            this.SignScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SignScore.Location = new System.Drawing.Point(340, 54);
            this.SignScore.Name = "SignScore";
            this.SignScore.Size = new System.Drawing.Size(55, 24);
            this.SignScore.TabIndex = 10;
            this.SignScore.Text = "Очки";
            this.SignScore.Click += new System.EventHandler(this.SignScore_Click);
            // 
            // Player1Score
            // 
            this.Player1Score.Location = new System.Drawing.Point(344, 82);
            this.Player1Score.Name = "Player1Score";
            this.Player1Score.ReadOnly = true;
            this.Player1Score.Size = new System.Drawing.Size(100, 22);
            this.Player1Score.TabIndex = 11;
            this.Player1Score.TextChanged += new System.EventHandler(this.Player1Score_TextChanged);
            // 
            // Player2Score
            // 
            this.Player2Score.Location = new System.Drawing.Point(344, 120);
            this.Player2Score.Name = "Player2Score";
            this.Player2Score.ReadOnly = true;
            this.Player2Score.Size = new System.Drawing.Size(100, 22);
            this.Player2Score.TabIndex = 12;
            this.Player2Score.TextChanged += new System.EventHandler(this.Player2Score_TextChanged);
            // 
            // Player3Score
            // 
            this.Player3Score.Location = new System.Drawing.Point(344, 164);
            this.Player3Score.Name = "Player3Score";
            this.Player3Score.ReadOnly = true;
            this.Player3Score.Size = new System.Drawing.Size(100, 22);
            this.Player3Score.TabIndex = 13;
            this.Player3Score.TextChanged += new System.EventHandler(this.Player3Score_TextChanged);
            // 
            // RaceCounter
            // 
            this.RaceCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RaceCounter.Location = new System.Drawing.Point(398, 259);
            this.RaceCounter.Name = "RaceCounter";
            this.RaceCounter.ReadOnly = true;
            this.RaceCounter.Size = new System.Drawing.Size(171, 28);
            this.RaceCounter.TabIndex = 14;
            // 
            // SignRaceCount
            // 
            this.SignRaceCount.AutoSize = true;
            this.SignRaceCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SignRaceCount.Location = new System.Drawing.Point(218, 259);
            this.SignRaceCount.Name = "SignRaceCount";
            this.SignRaceCount.Size = new System.Drawing.Size(163, 29);
            this.SignRaceCount.TabIndex = 15;
            this.SignRaceCount.Text = "Заезд номер";
            this.SignRaceCount.Click += new System.EventHandler(this.SignRaceCount_Click);
            // 
            // SignMaxRaces
            // 
            this.SignMaxRaces.AutoSize = true;
            this.SignMaxRaces.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SignMaxRaces.Location = new System.Drawing.Point(304, 223);
            this.SignMaxRaces.Name = "SignMaxRaces";
            this.SignMaxRaces.Size = new System.Drawing.Size(176, 24);
            this.SignMaxRaces.TabIndex = 16;
            this.SignMaxRaces.Text = "Игра до 5 заездов";
            this.SignMaxRaces.Click += new System.EventHandler(this.SignMaxRaces_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SignMaxRaces);
            this.Controls.Add(this.SignRaceCount);
            this.Controls.Add(this.RaceCounter);
            this.Controls.Add(this.Player3Score);
            this.Controls.Add(this.Player2Score);
            this.Controls.Add(this.Player1Score);
            this.Controls.Add(this.SignScore);
            this.Controls.Add(this.ButtonTurn);
            this.Controls.Add(this.Player2Range);
            this.Controls.Add(this.Player3Range);
            this.Controls.Add(this.Player1Range);
            this.Controls.Add(this.SignRange);
            this.Controls.Add(this.PlayerNumber2);
            this.Controls.Add(this.PlayerNumber3);
            this.Controls.Add(this.PlayerNumber1);
            this.Controls.Add(this.SignPlayerNumber);
            this.Controls.Add(this.GameName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GameName;
        private System.Windows.Forms.Label SignPlayerNumber;
        private System.Windows.Forms.TextBox PlayerNumber1;
        private System.Windows.Forms.TextBox PlayerNumber3;
        private System.Windows.Forms.TextBox PlayerNumber2;
        private System.Windows.Forms.Label SignRange;
        private System.Windows.Forms.TextBox Player1Range;
        private System.Windows.Forms.TextBox Player3Range;
        private System.Windows.Forms.TextBox Player2Range;
        private System.Windows.Forms.Button ButtonTurn;
        private System.Windows.Forms.Label SignScore;
        private System.Windows.Forms.TextBox Player1Score;
        private System.Windows.Forms.TextBox Player2Score;
        private System.Windows.Forms.TextBox Player3Score;
        private System.Windows.Forms.TextBox RaceCounter;
        private System.Windows.Forms.Label SignRaceCount;
        private System.Windows.Forms.Label SignMaxRaces;
    }
}

