using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Laba4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float Wide = 0;
        int[] LocalHeight;
        int Amount = 0;
        int MaxLocalHeight;
        Color[] customColor;

        private void Build_Click(object sender, EventArgs e)
        {
            Random Rand = new Random();
            Amount = Rand.Next(5, 20);

            LocalHeight = new int[Amount];
            customColor = new Color[Amount];

            for (int i = 0; i < Amount; i++)
            {
                LocalHeight[i] = Rand.Next(-100, 100);
                customColor[i] = Color.FromArgb(Rand.Next(0, 255), Rand.Next(0, 255), Rand.Next(0, 255));
            }

            MaxLocalHeight = LocalHeight.Max();

            Invalidate();
        }

        private void Read_Click(object sender, EventArgs e)
        {
            ReadFile("1.txt", out LocalHeight, out Amount, out customColor);

            MaxLocalHeight = LocalHeight.Max();

            Invalidate();
        }

        private void Write_Click(object sender, EventArgs e)
        {
            WriteFile("2.txt", LocalHeight, customColor);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics gGraphs = e.Graphics;
            Wide = 750 / (Amount * 2 - 1);

            gGraphs.DrawLine(new Pen(Color.Black, 1f), 20, 300, 770, 300);
            gGraphs.DrawLine(new Pen(Color.Black, 1f), 20, 100, 20, 500);

            for(int i = 0; i < Amount; i++)
            {
                SolidBrush Brush = new SolidBrush(customColor[i]);

                int DrawLocalHeight;
                float Temp;

                if (LocalHeight[i] > 0)
                {
                    DrawLocalHeight = 300 - LocalHeight[i] * 2;
                    Temp = 1;
                }
                else
                {
                    DrawLocalHeight = 300;
                    Temp = - 1/2;
                }
                gGraphs.FillRectangle(Brush, 20 + i * 2 * Wide, DrawLocalHeight, Wide, Math.Abs(LocalHeight[i] * 2));
                gGraphs.DrawString(LocalHeight[i].ToString(), new Font("Arial", 10), Brushes.Black, 20 + i * 2 * Wide, 300 - LocalHeight[i] * 2 - 15 * Temp);
                gGraphs.DrawString("100", new Font("Arial", 10), Brushes.Black, 10, 80);
                gGraphs.DrawString("-100", new Font("Arial", 10), Brushes.Black, 5, 500);
            }
        }

        static void ReadFile (string FilePath, out int[] LocalHeight, out int Amount, out Color[] customColor)
        {
            StreamReader File = new StreamReader(FilePath, Encoding.Default);
            string FileLine;
            Amount = 0;

            while ((FileLine = File.ReadLine()) != null)
            {   
                Amount++;
            }

            File = new StreamReader(FilePath, Encoding.Default);

            LocalHeight = new int[Amount];
            customColor = new Color[Amount];
            int Tempi = 0;

            while ((FileLine = File.ReadLine()) != null)
            {
                string[] Coloumn = FileLine.Split(':');

                LocalHeight[Tempi] = int.Parse(Coloumn[0]);
                customColor[Tempi] = Color.FromArgb(int.Parse(Coloumn[1]), int.Parse(Coloumn[2]), int.Parse(Coloumn[3]));

                Tempi++;
            }
        }

        static void WriteFile (string FilePath, int[] LocalHeight, Color[] customColor)
        {
            StreamWriter File = new StreamWriter(FilePath);

            var StrBld = new StringBuilder();

            for(int i = 0; i < LocalHeight.Length; i++)
            {
                StrBld.Append((LocalHeight[i]).ToString());
                StrBld.Append(":");
                StrBld.Append(customColor[i].R.ToString());
                StrBld.Append(":");
                StrBld.Append(customColor[i].G.ToString());
                StrBld.Append(":");
                StrBld.Append(customColor[i].B.ToString());
                File.Write(StrBld + "\n");
                StrBld.Clear();
            }

            File.Close();
        }
    }
}
