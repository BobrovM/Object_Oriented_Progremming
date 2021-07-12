using System;

namespace ConsoleApp1
{
    //Level1 problem 1
    /*class Program
    {
        static bool IsInCircle(double Radius, double CoordX, double CoordY)
        {
            bool InCircle = false;
            if (Math.Abs(CoordX * CoordX + CoordY * CoordY - Radius * Radius) <= 0.001)
            { InCircle = true; };
            return InCircle;
        }
        static void Main(string[] args)
        {
            double Radius = 2;
            double CoordX, CoordY;


            Console.WriteLine("Введите координату X:");
            CoordX = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату Y:");
            CoordY = double.Parse(Console.ReadLine());

            bool InCircle = IsInCircle(Radius, CoordX, CoordY);

            if (InCircle)
            {
                Console.WriteLine("Точка лежит на окружности.");
            }
            else
            {
                Console.WriteLine("Точка не лежит на окружности.");
            }
        }
    }*/



    //Level1 problem2
    /*class Program
    {
        static bool IsInRect(double CoordX, double CoordY)
        {
            bool InRect = false;
            if ((CoordY >= 0) && ((CoordY + Math.Abs(CoordX) < 1)))
            { InRect = true; };
            return InRect;
        }

        static void Main(string[] args)
        {
            double CoordX, CoordY;

            Console.WriteLine("Введите координату X:");
            CoordX = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату Y:");
            CoordY = double.Parse(Console.ReadLine());

            bool InRect = IsInRect(CoordX, CoordY);

            if (InRect)
            {
                Console.WriteLine("Точка лежит в треугольнике.");
            }
            else
            {
                Console.WriteLine("Точка не лежит в треугольнике.");
            };
        }
    }*/



    //Level2 problem1
    /*class Program
    {
        static void Main(string[] args)
        {
            const int Amount = 10;

            double Average = 0;

            for (int i = 1; i <= Amount; i++)
            {
                Console.WriteLine("Введите рост ученика № {0}.", i);
                Average += double.Parse(Console.ReadLine());
            }

            Average /= Amount;

            Console.WriteLine("Средний рост = {0}.", Average);
        }
    }*/



    //Level2 problem2
    /*class Program
    {
        static bool IsInCircle(double Radius, double CoordX, double CoordY)
        {
            bool InCircle = false;
            if (Math.Abs(Math.Pow(CoordX, 2) + Math.Pow(CoordY, 2) - Math.Pow(Radius, 2)) <= 0.001)
            { InCircle = true; };
            return InCircle;
        }

        static void Main(string[] args)
        {
            double Radius = 2;
            int InputAmount = 5, ApprovedAmount = 0;

            for (int i = 1; i <= InputAmount; i++)
            {
                Console.WriteLine("Введите координату X точки №{0}:", i);
                double CoordX = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите координату Y точки №{0}:", i);
                double CoordY = double.Parse(Console.ReadLine());

                if (IsInCircle(Radius, CoordX, CoordY))
                { ApprovedAmount++; };
            }

            Console.WriteLine("Количество точек в круге = {0}.", ApprovedAmount);
        }
    }*/



    //Level3 problem1
    /*class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во учеников");
            int Amount = int.Parse(Console.ReadLine());

            double Average = 0;

            for (int i = 1; i <= Amount; i++)
            {
                Console.WriteLine("Введите рост ученика № {0}.", i);
                Average += double.Parse(Console.ReadLine());
            }

            Average /= Amount;

            Console.WriteLine("Средний рост = {0}.", Average);
        }
    }*/



    //Level3 problem2
    class Program
    {
        static bool IsInCircle(double Radius, double CoordX, double CoordY)
        {
            bool InCircle = false;
            if (Math.Abs(Math.Pow(CoordX, 2) + Math.Pow(CoordY, 2) - Math.Pow(Radius, 2)) <= 0.001)
            { InCircle = true; };
            return InCircle;
        }

        static void Main(string[] args)
        {
            double Radius = 2;
            int ApprovedAmount = 0;

            while (true)
            {
                Console.WriteLine("Введите координату X:");
                double CoordX = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите координату Y:");
                double CoordY = double.Parse(Console.ReadLine());

                if (IsInCircle(Radius, CoordX, CoordY))
                { ApprovedAmount++; };

                Console.WriteLine("Введите 0, чтобы прекратить, или любое другое число, чтобы продолжить:");
                if (double.Parse(Console.ReadLine()) == 0) { break; };
            }

            Console.WriteLine("Количество точек в круге = {0}.", ApprovedAmount);
        }
    }
}
