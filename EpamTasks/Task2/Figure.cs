using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    abstract class Point 
    {
        public Point(){}
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
        public double X { get; set; }
        public double Y { get; set; }
    }
    class Line : Point
    {
      
        public Line() {}
        public Line(double x, double y, double x1, double y1) : base(x, y)
        {
            X1 = x1;
            Y1 = y1;
           
        }
        public double X1 { get; set; }
        public double Y1 { get; set; }
        public double Length
        {
            get {if(Math.Sqrt((X - X1) * (X - Y1) + (X1 - Y1) * (X1 - Y1))==0) throw new ArgumentException("Нельзя построить линию с заданными координатами");
                return Math.Sqrt((X - X1) * (X - Y1) + (X1 - Y1) * (X1 - Y1));}
            private set { }
        } 
    }
        class Circumferece : Point
        {
            private double radius;
            protected const double PI = 3.14;
            public Circumferece() { X = Y = 0.0; }
            public Circumferece(double x, double y, double r) : base(x, y)
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
            public double Length
            {
                get { return 2 * PI * radius; }
                private set { }
            }
        }
        class Rectangle : Point
        {
        private double width;
        private double height;
        public Rectangle() { }
        public Rectangle(double x, double y) : base(x, y) { }//Задает первоначальные координаты
        public Rectangle(double x, double y,double w, double h):base(x,y)//задает первоначальные кординаты, длину и ширину
        {
            Width = w;
            Height = h;
        }
        public double Width { get { return width; } set { if (value < 0) throw new ArgumentException("Ширина не может быть отрицательной");width = value; } }
        public double Height{get { return height; } set { if (value < 0) throw new ArgumentException("Высота не может быть отрицательной");  height= value; } }
        public virtual double Area { get { return Width * Height; } private set { } }
        
        
        }
    class Round : Circumferece
    {

        public Round(double x = 0, double y = 0, double r = 1) : base(x, y, r)
        {
            X = x;
            Y = y;
            Radius = r;
        }
        public double Area
        {
            get { return PI * Radius * Radius; }
        }
    }
    class Triangle
    {
        private double a;
        private double b;
        private double c;
        public Triangle(double a = 1, double b = 1, double c = 1)
        {
            A = a;
            B = b;
            C = c;
            if (A >= B + C)
                throw new ArgumentException("Невозможно создать треугольник со стороной a");
            if (B >= A + C)
                throw new ArgumentException("Невозможно создать треугольник со стороной b");
            if (C >= B + A)
                throw new ArgumentException("Невозможно создать треугольник со стороной c");

        }
        public double A
        {
            private set
            {
                if (value <= 0)
                    throw new ArgumentException("Значение стороны а должно быть положительным");
                a = value;
            }
            get { return a; }
        }
        public double B
        {
            private set
            {
                if (value <= 0)
                    throw new ArgumentException("Значение стороны b должно быть положительным");
                b = value;
            }
            get { return b; }
        }
        public double C
        {
            private set
            {
                if (value <= 0)
                    throw new ArgumentException("Значение стороны c должно быть положительным");
                c = value;
            }
            get { return c; }
        }
        public double TrianglePerimetr
        {
            get { return A + B + C; }
        }
        public double TriangleArea
        {
            get { return Math.Sqrt(((TrianglePerimetr / 2) * (TrianglePerimetr / 2 - a) * (TrianglePerimetr / 2 - b) * (TrianglePerimetr / 2 - c))); }
        }
    }
    class Ring : Round
    {
        public Ring(double x = 0, double y = 0, double r = 1, double r2 = 2) : base(x, y, r)
        {
            OutsideRadius = r2;
        }
        private double outsideradius;
        public double OutsideRadius { set { if (value <= Radius) throw new ArgumentException("Значение внешнего радиуса должно быть больше внутреннего"); outsideradius = value; } get { return outsideradius; } }
        public double OutsideCircumference { get { return 2 * PI * outsideradius; } }
        public double SumOfCircumference { get { return Length + OutsideCircumference; } }
        public new double Area { get { return PI * (OutsideRadius * OutsideRadius - Radius * Radius); } }
    }

}
