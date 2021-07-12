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

        private class Columns
        {
            internal int ColumnHigth { get; set; }
            internal Color ColumnColor { get; }

            public Columns(int InputColoumnHight, int Red, int Green, int Blue)
            {
                ColumnHigth = InputColoumnHight;
                ColumnColor = Color.FromArgb(Red, Green, Blue);
            }
        }


        private List<Columns> ColumnsList = new List<Columns>();
        float Wide = 0;
        int Amount = 0;
        int MaxLocalHeight;
        bool IsClicked = false;

        private void Build_Click(object sender, EventArgs e)
        {
            IsClicked = true;
            Random Rand = new Random();
            Amount = Rand.Next(5, 20);
            MaxLocalHeight = 0;
            ColumnsList.Clear();

            for (int i = 0; i < Amount; i++)
            {
                Columns Temp = new Columns(Rand.Next(-100, 100), Rand.Next(0, 255), Rand.Next(0, 255), Rand.Next(0, 255));
                ColumnsList.Add(Temp);
                if(Math.Abs(Temp.ColumnHigth) > MaxLocalHeight) { MaxLocalHeight = Math.Abs(Temp.ColumnHigth); };
            }

            Invalidate();
        }

        private void Read_Click(object sender, EventArgs e)
        {
            ReadFile("1.txt", out Amount, out MaxLocalHeight);

            IsClicked = true;
            Invalidate();
        }

        private void Write_Click(object sender, EventArgs e)
        {
            WriteFile("2.txt");
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics gGraphs = e.Graphics;
            if (IsClicked)
            {
                Wide = 750f / (float)(Amount * 2 - 1);
            }

            gGraphs.DrawLine(new Pen(Color.Black, 1f), 20, 300, 770, 300);
            gGraphs.DrawLine(new Pen(Color.Black, 1f), 20, 100, 20, 500);

            for(int i = 0; i < Amount; i++)
            {
                SolidBrush Brush = new SolidBrush(ColumnsList[i].ColumnColor);

                float DrawLocalHeight;
                float Temp;
                float Koef = (float)MaxLocalHeight * 2 / 200f;

                if (ColumnsList[i].ColumnHigth > 0)
                {
                    DrawLocalHeight = 300 - ColumnsList[i].ColumnHigth * 2f / Koef;
                    Temp = 1;
                }
                else
                {
                    DrawLocalHeight = 300;
                    Temp = - 1/2;
                }
                gGraphs.FillRectangle(Brush, 20 + i * 2 * Wide, DrawLocalHeight, Wide, Math.Abs((float)ColumnsList[i].ColumnHigth * 2f / Koef));
                gGraphs.DrawString(ColumnsList[i].ColumnHigth.ToString(), new Font("Arial", 10), Brushes.Black, 20 + i * 2 * Wide + (float)(Wide/2 - 10), 300f - ColumnsList[i].ColumnHigth * 2 / Koef - 15 * Temp);
                gGraphs.DrawString(MaxLocalHeight.ToString(), new Font("Arial", 10), Brushes.Black, 10, 80);
                gGraphs.DrawString((-1 * MaxLocalHeight).ToString(), new Font("Arial", 10), Brushes.Black, 5, 500);
            }
            IsClicked = false;
        }

        void ReadFile (string FilePath, out int Amount, out int LocalMaxHeight)
        {
            StreamReader File = new StreamReader(FilePath, Encoding.Default);
            string FileLine;
            Amount = 0;
            LocalMaxHeight = 0;
            ColumnsList.Clear();

            while ((FileLine = File.ReadLine()) != null)
            {
                string[] Coloumn = FileLine.Split(':');
                Columns Temp = new Columns(int.Parse(Coloumn[0]), int.Parse(Coloumn[1]), int.Parse(Coloumn[2]), int.Parse(Coloumn[3]));

                ColumnsList.Add(Temp);

                if (Math.Abs(Temp.ColumnHigth) > MaxLocalHeight) { MaxLocalHeight = Math.Abs(Temp.ColumnHigth); };
                Amount++;
            }
        }

        void WriteFile (string FilePath)
        {
            StreamWriter File = new StreamWriter(FilePath);

            var StrBld = new StringBuilder();

            for(int i = 0; i < ColumnsList.Count; i++)
            {
                StrBld.Append((ColumnsList[i].ColumnHigth).ToString());
                StrBld.Append(":");
                StrBld.Append(ColumnsList[i].ColumnColor.R.ToString());
                StrBld.Append(":");
                StrBld.Append(ColumnsList[i].ColumnColor.G.ToString());
                StrBld.Append(":");
                StrBld.Append(ColumnsList[i].ColumnColor.B.ToString());
                File.Write(StrBld + "\n");
                StrBld.Clear();
            }

            File.Close();
        }
    }
}
