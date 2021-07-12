using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ur3_Zad1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            int[] Player = new int[3];

            int Counter = 0;
            while(Counter < 3)
            {
                var Rand = new Random();
                bool SameNumber = false;
                Player[Counter] = Rand.Next(1, 100);

                for (int j = 0; j <= Counter; j++)
                {
                    if(Counter != j)
                    {
                        if(Player[Counter] == Player[j]) { SameNumber = true; };
                    }
                }
                
                if(SameNumber) { continue; };

                Counter++;
            }

            PlayerNumber1.Text = Player[0].ToString();
            PlayerNumber2.Text = Player[1].ToString();
            PlayerNumber3.Text = Player[2].ToString();

            Player1Range.Text = "0";
            Player2Range.Text = "0";
            Player3Range.Text = "0";

            Player1Score.Text = "0";
            Player2Score.Text = "0";
            Player3Score.Text = "0";

            RaceCounter.Text = "1";
        }

        private void GameName_Click(object sender, EventArgs e)
        {

        }

        private void SignPlayerNumber_Click(object sender, EventArgs e)
        {

        }

        private void PlayerNumber1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PlayerNumber2_TextChanged(object sender, EventArgs e)
        {

        }

        private void PlayerNumber3_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignRange_Click(object sender, EventArgs e)
        {

        }

        private void Player1Range_TextChanged(object sender, EventArgs e)
        {

        }

        private void Player2Range_TextChanged(object sender, EventArgs e)
        {

        }

        private void Player3Range_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonTurn_Click(object sender, EventArgs e)
        {
            var Rand = new Random();
            int[] PlayerRange = new int[3];

            PlayerRange[0] = int.Parse(Player1Range.Text);
            PlayerRange[1] = int.Parse(Player2Range.Text);
            PlayerRange[2] = int.Parse(Player3Range.Text);

            PlayerRange[0] += Rand.Next(1, 6);
            PlayerRange[1] += Rand.Next(1, 6);
            PlayerRange[2] += Rand.Next(1, 6);

            if (PlayerRange[0] >= 50)
            {
                Player1Score.Text = (5 + int.Parse(Player1Score.Text)).ToString();
                Player1Range.Text = "0";
                Player2Range.Text = "0";
                Player3Range.Text = "0";
                RaceCounter.Text = (1 + int.Parse(RaceCounter.Text)).ToString();
            }
            else
            if (PlayerRange[1] >= 50)
            {
                Player2Score.Text = (5 + int.Parse(Player2Score.Text)).ToString();
                Player1Range.Text = "0";
                Player2Range.Text = "0";
                Player3Range.Text = "0";
                RaceCounter.Text = (1 + int.Parse(RaceCounter.Text)).ToString();
            }
            else
            if (PlayerRange[2] >= 50)
            {
                Player3Score.Text = (5 + int.Parse(Player3Score.Text)).ToString();
                Player1Range.Text = "0";
                Player2Range.Text = "0";
                Player3Range.Text = "0";
                RaceCounter.Text = (1 + int.Parse(RaceCounter.Text)).ToString();
            }
            else
            {
                Player1Range.Text = PlayerRange[0].ToString();
                Player2Range.Text = PlayerRange[1].ToString();
                Player3Range.Text = PlayerRange[2].ToString();
            }


            if(int.Parse(RaceCounter.Text) > 5)
            {
                ButtonTurn.Enabled = false;
                RaceCounter.Text = "Конец скачек";

                if((int.Parse(Player1Score.Text) > int.Parse(Player2Score.Text))
                    && (int.Parse(Player1Score.Text) > int.Parse(Player3Score.Text)))
                {
                    GameName.Text = "Победил участник  № " + PlayerNumber1.Text;
                }
                else if ((int.Parse(Player2Score.Text) > int.Parse(Player1Score.Text))
                    && (int.Parse(Player2Score.Text) > int.Parse(Player3Score.Text)))
                {
                    GameName.Text = "Победил участник  № " + PlayerNumber2.Text;
                }
                else if ((int.Parse(Player3Score.Text) > int.Parse(Player1Score.Text))
                    && (int.Parse(Player3Score.Text) > int.Parse(Player2Score.Text)))
                {
                    GameName.Text = "Победил участник № " + PlayerNumber3.Text;
                }
            }
        }

        private void SignScore_Click(object sender, EventArgs e)
        {

        }

        private void Player1Score_TextChanged(object sender, EventArgs e)
        {

        }

        private void Player2Score_TextChanged(object sender, EventArgs e)
        {

        }

        private void Player3Score_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SignRaceCount_Click(object sender, EventArgs e)
        {

        }

        private void SignMaxRaces_Click(object sender, EventArgs e)
        {

        }
    }
}
