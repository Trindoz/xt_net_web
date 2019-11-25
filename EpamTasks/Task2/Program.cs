using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Round a = new Round();
            Triangle b = new Triangle();
            Console.WriteLine("Кординаты центра круга: " + a.X +" "+ a.Y);
            Console.WriteLine("Радиус: "+a.Radius);
            Console.WriteLine("Длина окружности: "+a.Circumference);
            Console.WriteLine("Площадь круга: " + a.CircleArea);
            Console.WriteLine("Площадь треугольника: " + b.TriangleArea);
        }
    }
    class Round
    {
        private double radius;
        const double PI = 3.14;
        public double X;
        public double Y;
        public Round(double x=0, double y=0, double r=1)
        {
            X = x;
            Y = y;
            Radius = r;
        }
       public double Radius
        {
            set 
            { 
                if (value <= 0)
                    throw new ArgumentException("Значение радиуса должно быть положительным");
                radius = value;
            }
            get { return radius; }
        }
        public double Circumference
        {
            get { return 2 * PI * radius; }
        }
        public double CircleArea
        {
            get { return PI * radius * radius; }
        }
    }
    class Triangle
    {
        private double a;
        private double b;
        private double c;
        public Triangle(double a=1,double b=1, double c=1)
        {
            A = a;
            B = b;
            C = c;
        }
        public double A
        {
            set { if (value <= 0)
                    throw new ArgumentException("Значение должно быть положительным");
                a = value;
            }
            get { return a; }
        }
        public double B
        {
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Значение должно быть положительным");
                b = value;
            }
            get { return b; }
        }
        public double C
        {
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Значение должно быть положительным");
                c = value;
            }
            get { return c; }
        }
        public double TrianglePerimetr
        {
            get { return a + b + c; }
        }
        public double TriangleArea
        {
            get { return Math.Sqrt(((TrianglePerimetr / 2) * (TrianglePerimetr / 2 - a) * (TrianglePerimetr / 2 - b) * (TrianglePerimetr / 2 - c))); }
        }
    }
}
