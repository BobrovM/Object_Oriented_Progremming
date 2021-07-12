using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KrestikiNolixi3X3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[,] Field = new int[10, 10];
        int Turn = 1;
        int WinXS, WinYS, WinXF, WinYF;
        bool IsX = false, IsScoreChanged = false, IsWin = false;

        private void PlayerXScore_Click(object sender, EventArgs e)
        {

        }

        private void Player0Score_Click(object sender, EventArgs e)
        {

        }

        private void PlayerXScoreCount_Click(object sender, EventArgs e)
        {

        }

        private void Player0ScoreCounter_Click(object sender, EventArgs e)
        {

        }

        private void ButtonNewMatch_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Field[i, j] = 0;
                }
            }
            IsClickAllowed = true;
            IsScoreChanged = false;
            IsWin = false;
            Turn = 1;

            Invalidate();
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            PlayerXScoreCount.Text = "0";
            Player0ScoreCounter.Text = "0";

            for(int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Field[i, j] = 0;
                }
            }

            IsClickAllowed = true;
            IsScoreChanged = false;
            IsWin = false;
            Turn = 1;

            Invalidate();
        }

        bool IsClickAllowed = true;

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics gLine = e.Graphics;

            int x = 0;

            for(int i = 0; i < 11; i++)
            {
                x++;

                gLine.DrawLine(new Pen(Color.Black, 5f), 25, x*50-25, 525, x*50-25);
                gLine.DrawLine(new Pen(Color.Black, 5f), x*50-25, 25, x*50-25, 525);
            }

            for(int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    if(Field[i, j] == 1)
                    {
                        gLine.DrawLine(new Pen(Color.Red, 5f), (i + 1) * 50 - 22, (j + 1) * 50 - 22,
                            (i + 1) * 50 + 22, (j + 1) * 50 + 22);
                        gLine.DrawLine(new Pen(Color.Red, 5f), (i + 1) * 50 - 22, (j + 1) * 50 + 22,
                            (i + 1) * 50 + 22, (j + 1) * 50 - 22);
                    }
                    else if(Field[i, j] == 2)
                    {
                        gLine.DrawEllipse(new Pen(Color.Blue, 5f), (i + 1) * 50 - 22, (j + 1) * 50 - 22, 44, 44);
                    }
                }
            }

            //При выйгрыше
            if(!IsClickAllowed && !IsScoreChanged)
            {
                gLine.DrawLine(new Pen(Color.Yellow, 15f), (WinXS + 1) * 50, (WinYS + 1) * 50,
                            (WinXF + 1) * 50, (WinYF + 1) * 50);

                if (IsWin)
                {
                    if (IsX)
                    {
                        int temp = int.Parse(PlayerXScoreCount.Text);
                        temp++;
                        PlayerXScoreCount.Text = temp.ToString();
                        IsScoreChanged = true;
                        MessageBox.Show("Выйграл игрок с крестиками!", "Матч закончен!", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information,
                                MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                    }
                    else
                    {
                        int temp = int.Parse(Player0ScoreCounter.Text);
                        temp++;
                        Player0ScoreCounter.Text = temp.ToString();
                        IsScoreChanged = true;
                        MessageBox.Show("Выйграл игрок с ноликами!", "Матч закончен!",
                            MessageBoxButtons.OK, MessageBoxIcon.Information,
                                MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                    }
                };

                if (!IsWin && Turn == 101)
                {
                    int temp = int.Parse(Player0ScoreCounter.Text);
                    temp++;
                    Player0ScoreCounter.Text = temp.ToString();
                    IsScoreChanged = true;
                    MessageBox.Show("Ничья!", "Матч закончен!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information,
                            MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                }
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if(IsClickAllowed)
            {
                int ClickLocX = (e.X + 25) / 50 - 1;
                int ClickLocY = (e.Y + 25) / 50 - 1;

                if ((ClickLocX >= 0) && (ClickLocX <= 9) && (ClickLocY >= 0) && (ClickLocY <= 9) && (0 == Field[ClickLocX, ClickLocY]))
                {
                    if ((Turn % 2) == 1)
                    {
                        Field[ClickLocX, ClickLocY] = 1;
                        IsX = true;
                    }
                    else
                    {
                        Field[ClickLocX, ClickLocY] = 2;
                        IsX = false;
                    }
                    Turn++;


                    //Проверка на выйгрыш
                    //Слева направо
                    if (ClickLocX <= 5)
                    {
                        for (int i = 1; i <= 4; i++)
                        {
                            if (Field[ClickLocX, ClickLocY] != Field[ClickLocX + i, ClickLocY]) { break; };
                            if (i == 4)
                            {
                                WinXS = ClickLocX;
                                WinXF = ClickLocX + 4;
                                WinYS = ClickLocY;
                                WinYF = ClickLocY;
                                IsClickAllowed = false;
                                IsWin = true;
                            }
                        }
                    }

                    //Справа налево
                    if (ClickLocX >= 4)
                    {
                        for (int i = 1; i <= 4; i++)
                        {
                            if (Field[ClickLocX, ClickLocY] != Field[ClickLocX - i, ClickLocY]) { break; };
                            if (i == 4)
                            {
                                WinXS = ClickLocX;
                                WinXF = ClickLocX - 4;
                                WinYS = ClickLocY;
                                WinYF = ClickLocY;
                                IsClickAllowed = false;
                                IsWin = true;
                            }
                        }
                    }

                    //Сверху вниз
                    if (ClickLocY <= 5)
                    {
                        for (int i = 1; i <= 4; i++)
                        {
                            if (Field[ClickLocX, ClickLocY] != Field[ClickLocX, ClickLocY + i]) { break; };
                            if (i == 4)
                            {
                                WinXS = ClickLocX;
                                WinXF = ClickLocX;
                                WinYS = ClickLocY;
                                WinYF = ClickLocY + 4;
                                IsClickAllowed = false;
                                IsWin = true;
                            }
                        }
                    }

                    //Снизу вверх
                    if (ClickLocY >= 4)
                    {
                        for (int i = 1; i <= 4; i++)
                        {
                            if (Field[ClickLocX, ClickLocY] != Field[ClickLocX, ClickLocY - i]) { break; };
                            if (i == 4)
                            {
                                WinXS = ClickLocX;
                                WinXF = ClickLocX;
                                WinYS = ClickLocY;
                                WinYF = ClickLocY - 4;
                                IsClickAllowed = false;
                                IsWin = true;
                            }
                        }
                    }

                    //Слева сверху направо вниз
                    if ((ClickLocX <= 5) && (ClickLocY <= 5))
                    {
                        for (int i = 1; i <= 4; i++)
                        {
                            if (Field[ClickLocX, ClickLocY] != Field[ClickLocX + i, ClickLocY + i]) { break; };
                            if (i == 4)
                            {
                                WinXS = ClickLocX;
                                WinXF = ClickLocX + 4;
                                WinYS = ClickLocY;
                                WinYF = ClickLocY + 4;
                                IsClickAllowed = false;
                                IsWin = true;
                            }
                        }
                    }

                    //Слева снизу направо вверх
                    if ((ClickLocX <= 5) && (ClickLocY >= 4))
                    {
                        for (int i = 1; i <= 4; i++)
                        {
                            if (Field[ClickLocX, ClickLocY] != Field[ClickLocX + i, ClickLocY - i]) { break; };
                            if (i == 4)
                            {
                                WinXS = ClickLocX;
                                WinXF = ClickLocX + 4;
                                WinYS = ClickLocY;
                                WinYF = ClickLocY - 4;
                                IsClickAllowed = false;
                                IsWin = true;
                            }
                        }
                    }

                    //Справа сверху налево вниз
                    if ((ClickLocX >= 4) && (ClickLocY <= 5))
                    {
                        for (int i = 1; i <= 4; i++)
                        {
                            if (Field[ClickLocX, ClickLocY] != Field[ClickLocX - i, ClickLocY + i]) { break; };
                            if (i == 4)
                            {
                                WinXS = ClickLocX;
                                WinXF = ClickLocX - 4;
                                WinYS = ClickLocY;
                                WinYF = ClickLocY + 4;
                                IsClickAllowed = false;
                                IsWin = true;
                            }
                        }
                    }

                    //Справа снизу налево вверх
                    if ((ClickLocX >= 4) && (ClickLocY >= 4))
                    {
                        for (int i = 1; i <= 4; i++)
                        {
                            if (Field[ClickLocX, ClickLocY] != Field[ClickLocX - i, ClickLocY - i]) { break; };
                            if (i == 4)
                            {
                                WinXS = ClickLocX;
                                WinXF = ClickLocX - 4;
                                WinYS = ClickLocY;
                                WinYF = ClickLocY - 4;
                                IsClickAllowed = false;
                                IsWin = true;
                            }
                        }
                    }
                };


                if(Turn == 101)
                {
                    IsClickAllowed = false;
                    if (!IsWin)
                    {
                        WinXS = -9999;
                        WinXF = -9999;
                        WinYS = -9999;
                        WinYF = -9999;
                    }
                }

                Invalidate();
            }
        }
    }
}
