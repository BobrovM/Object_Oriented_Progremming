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

namespace Laba6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class GeometricFigure //Base class
        {
            protected Random random = new Random(DateTime.Now.Millisecond);
            private Form form;

            public GeometricFigure(Form form)
            {
                this.form = form;
            }

            protected Point CenterPoint;
            public Color BaseColor;
            protected int Size;
            protected string Name;
            public bool IsFigureClicked;

            public void CreateCenterPoint()
            {
                CenterPoint = new Point
                {
                    X = random.Next(0 + Size / 2, form.ClientSize.Width - Size / 2),
                    Y = random.Next(0 + Size / 2, form.ClientSize.Height - Size / 2)
                };
            }

            public void CreateColor()
            {
                BaseColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
            }

            public void CreateSize()
            {
                Size = random.Next(50, 151);
            }

            public Point GetCenterPoint() { return CenterPoint; }

            public string GetName() { return Name; }

            public int GetSize() { return Size; }

            public void SetCenterPoint(Point point) => CenterPoint = point;

            public void SetSize(int InSize) => Size = InSize;

            public virtual double GetArea()
            {
                return Size;
            }

            public virtual void Draw(PaintEventArgs e)
            {
                
            }

            public virtual bool CheckPoint()
            {
                return false;
            }

            public virtual bool FigureChoose(int ClickX, int ClickY)
            {
                return false;
            }
        }


        List<GeometricFigure> GeometricFigures = new List<GeometricFigure>();
        bool IsSomethingCreated = false;

        class Square : GeometricFigure //Class Square
        {
            public Square(Form form) : base(form)
            {
            }

            public override double GetArea() => Math.Round(Math.Pow(Size, 2), 2); //Area of square


            public override void Draw(PaintEventArgs e)
            {
                Name = "Квадрат";

                Brush brush = new SolidBrush(BaseColor);

                e.Graphics.FillRectangle(brush, CenterPoint.X - Size / 2f, CenterPoint.Y - Size / 2f, Size, Size);

                if(IsFigureClicked)
                {
                    PointF InfoPoint = new PointF(CenterPoint.X - Size / 4, CenterPoint.Y - Size / 4);
                    string Temp = GetName() + "\nРазмер: " + GetSize().ToString() + "\nПлощадь: " + GetArea().ToString();
                    e.Graphics.DrawString(Temp, DefaultFont, Brushes.Black, InfoPoint);
                }
            }

            public override bool FigureChoose(int ClickX, int ClickY)
            {
                if(ClickX >= CenterPoint.X - Size / 2 && ClickX <= CenterPoint.X + Size / 2
                    && ClickY >= CenterPoint.Y - Size / 2 && ClickY <= CenterPoint.Y + Size / 2)
                {
                    IsFigureClicked = true;
                    return true;
                }

                return false;
            }
        }


        class Circle : GeometricFigure //Class Circle
        {
            public Circle(Form form) : base(form)
            {
            }

            public override double GetArea() => Math.Round(Math.PI * Math.Pow(Size / 2, 2), 2);

            public override void Draw(PaintEventArgs e)
            {
                Name = "Круг";

                Brush brush = new SolidBrush(BaseColor);

                e.Graphics.FillEllipse(brush, CenterPoint.X - Size / 2f, CenterPoint.Y - Size / 2f, Size, Size);

                if (IsFigureClicked)
                {
                    PointF InfoPoint = new PointF(CenterPoint.X - Size / 4, CenterPoint.Y - Size / 4);
                    string Temp = GetName() + "\n" + GetSize().ToString() + "\n" + GetArea().ToString();
                    e.Graphics.DrawString(Temp, DefaultFont, Brushes.Black, InfoPoint);
                }
            }
            
            public override bool FigureChoose(int ClickX, int ClickY)
            {
                if(Math.Sqrt(Math.Pow(ClickX - CenterPoint.X, 2) + Math.Pow(ClickY - CenterPoint.Y, 2)) <= Size / 2)
                {
                    IsFigureClicked = true;
                    return true;
                }

                return false;
            }
        }


        class Triangle : GeometricFigure //Class Triangle
        {
            public Triangle(Form form) : base(form)
            {
            }

            public override double GetArea() => Math.Round(Math.Pow(Size * 2 / Math.Sqrt(2), 2), 2);


            public override void Draw(PaintEventArgs e)
            {
                Name = "Треугольник";

                Brush brush = new SolidBrush(BaseColor);
                float SideHalf = Convert.ToSingle((Size / Math.Sin(0.785398)) / 2); 

                PointF Point1 = new PointF(CenterPoint.X + SideHalf, CenterPoint.Y + SideHalf);
                PointF Point2 = new PointF(CenterPoint.X - SideHalf, CenterPoint.Y + SideHalf);
                PointF Point3 = new PointF(CenterPoint.X - SideHalf, CenterPoint.Y - SideHalf);

                PointF[] TrianglePoints = { Point1, Point2, Point3};

                e.Graphics.FillPolygon(brush, TrianglePoints);
                PointF InfoPoint = new PointF(CenterPoint.X - SideHalf / 1.5f, CenterPoint.Y + SideHalf / 4);

                if (IsFigureClicked)
                {
                    string Temp = GetName() + "\n" + GetSize().ToString() + "\n" + GetArea().ToString();
                    e.Graphics.DrawString(Temp, DefaultFont, Brushes.Black, InfoPoint);
                }
            }

            public override bool FigureChoose(int ClickX, int ClickY)
            {
                float SideHalf = Convert.ToSingle((Size / Math.Sin(0.785398)) / 2);

                if ((ClickY - CenterPoint.Y) >= (ClickX - CenterPoint.X) && ClickX >= CenterPoint.X - SideHalf && ClickX <= CenterPoint.X + SideHalf
                    && ClickY >= CenterPoint.Y - SideHalf && ClickY <= CenterPoint.Y + SideHalf)
                {
                    IsFigureClicked = true;
                    return true;
                }

                return false;
            }
        }

        //create button
        private void Button_Create_Click(object sender, EventArgs e)
        {
            Random Rand = new Random();
            int FigureNumber = Rand.Next(0, 3);

            if (FigureNumber == 0)
            {
                GeometricFigures.Add(new Square(this));
            }
            else if (FigureNumber == 1)
            {
                GeometricFigures.Add(new Circle(this));
            }
            else if (FigureNumber == 2)
            {
                GeometricFigures.Add(new Triangle(this));
            }

            GeometricFigures[GeometricFigures.Count - 1].CreateSize();
            GeometricFigures[GeometricFigures.Count - 1].CreateColor();
            GeometricFigures[GeometricFigures.Count - 1].CreateCenterPoint();
            IsSomethingCreated = true;

            Invalidate();
        }

        //file saving
        private void Button_Save_Click(object sender, EventArgs e)
        {
            //file saving scheme: (Name:CenterPoint.X:CenterPoint.Y:Size:Color.R:Color.G:Color.B)
            StreamWriter SW = new StreamWriter("FigureSave.txt");

            var SB = new StringBuilder();
            
            for(int i = 0; i < GeometricFigures.Count; i++)
            {
                SB.Append(GeometricFigures[i].GetName());
                SB.Append(":");
                SB.Append(GeometricFigures[i].GetCenterPoint().X.ToString());
                SB.Append(":");
                SB.Append(GeometricFigures[i].GetCenterPoint().Y.ToString());
                SB.Append(":");
                SB.Append(GeometricFigures[i].GetSize().ToString());
                SB.Append(":");
                SB.Append(GeometricFigures[i].BaseColor.R.ToString());
                SB.Append(":");
                SB.Append(GeometricFigures[i].BaseColor.G.ToString());
                SB.Append(":");
                SB.Append(GeometricFigures[i].BaseColor.B.ToString());
                SW.Write(SB + "\n");
                SB.Clear();
            }

            SW.Close();
        }

        //load same file from savings
        private void Button_Load_Click(object sender, EventArgs e)
        {
            //file reading scheme: (Name:CenterPoint.X:CenterPoint.Y:Size:Color.R:Color.G:Color.B)

            StreamReader SR = new StreamReader("FigureSave.txt", Encoding.UTF8);
            string Line;
            GeometricFigures.Clear();
            int Count = 0;

            while((Line = SR.ReadLine()) != null)
            {
                string[] Splited = Line.Split(':');

                if (Splited[0] == "Квадрат")
                {
                    GeometricFigures.Add(new Square(this));
                }
                else if(Splited[0] == "Круг")
                {
                    GeometricFigures.Add(new Circle(this));
                }
                else if(Splited[0] == "Треугольник")
                {
                    GeometricFigures.Add(new Triangle(this));
                }

                Point TempPoint = new Point(int.Parse(Splited[1]), int.Parse(Splited[2]));

                GeometricFigures[Count].SetCenterPoint(TempPoint);

                GeometricFigures[Count].SetSize(int.Parse(Splited[3]));

                Color TempColor = new Color();
                TempColor = Color.FromArgb(int.Parse(Splited[4]), int.Parse(Splited[5]), int.Parse(Splited[6]));

                GeometricFigures[Count].BaseColor = TempColor;

                Count++;
            }

            SR.Close();
            IsSomethingCreated = true;
            Invalidate();
        }

        //every figure from the list must be on screen
        //clicking on a figure must show information about it
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if(!IsSomethingCreated) { return; }

            Graphics DrawFigures = e.Graphics;

            for (int Index = 0; Index < GeometricFigures.Count; Index++)
            {
                GeometricFigures[Index].Draw(e);
            }
        }


        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if(!IsSomethingCreated) { return; }

            for(int Index = 0; Index < GeometricFigures.Count; Index++)
            {
                GeometricFigures[Index].IsFigureClicked = false;
                GeometricFigures[Index].FigureChoose(e.X, e.Y);
            }

            Invalidate();
        }
    }
}