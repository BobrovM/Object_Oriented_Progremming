using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uroven2_Zadanie1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics Graph = e.Graphics;
            Graph.TranslateTransform(this.Width / 2, this.Height / 2);
            Graph.DrawLine(new Pen(Color.Brown, 1.0f), -960, 0, 960, 0);
            Graph.DrawLine(new Pen(Color.Brown, 1.0f), 0, -540, 0, 540);

            double x, z;

            for(x = -Math.PI; x <= Math.PI; x += Math.PI / 50)
            {
                z = 2 * Math.Sin(x) + Math.Sin(2 * x);
                Graph.DrawEllipse(new Pen(Color.Blue, 2.0f), 50 * (float)x, 50 * (float)z, 1, 1);
            }
        }
    }
}
