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

            Round round = new Round();
            round.X = 5;
            round.Y = 7;
            Console.WriteLine("Кординаты центра круга: " + round.X + " " + round.Y);
            Console.WriteLine("Радиус: " + round.Radius);
            Console.WriteLine("Длина окружности: " + round.Circumference);
            Console.WriteLine("Площадь круга: " + round.CircleArea);
            Ring ring = new Ring();
            ring.X = 3;
            ring.Y = 4;
            ring.OutsideRadius = 4;
            Console.WriteLine("Кординаты центра кольца: " + ring.X + " " + ring.Y);
            Console.WriteLine("Внутрений радиус: " + ring.Radius);
            Console.WriteLine("Внешний радиус: " + ring.OutsideRadius);
            Console.WriteLine("Длина внутренней окружности: " + ring.Circumference);
            Console.WriteLine("Длина внешней окружности: " + ring.OutsideCircumference);
            Console.WriteLine("Сумма двух окружностей:" + ring.SumOfCircumference);
            Console.WriteLine("Площадь кольца: " + ring.RingArea);
            Triangle triangle= new Triangle(3,2,3);
            Console.WriteLine("Периметр треугольника: " + triangle.TrianglePerimetr);
            Console.WriteLine("Площадь треугольника: " + triangle.TriangleArea);
            User user = new User("Иван", "Иванович", "Иванов");
            user.Birthday = new DateTime(1990, 01, 01);
            Console.WriteLine(user.Name+" "+user.SecondName+" "+user.Surname+" "+user.Birthday+" "+user.Age);
            Employee employee = new Employee();
            employee.Name = "Петр";
            employee.SecondName = "Петрович";
            employee.Surname = "Петров";
            employee.Birthday = new DateTime(1980, 01, 01);
            Console.WriteLine(employee.Name + " " + employee.SecondName + " " + employee.Surname + " " + employee.Birthday + " " + employee.Age);
            
            
           
        }
    }
    class Round
    {
        private double radius;
        protected const double PI = 3.14;
        public double X;
        public double Y;
        public Round(double x = 0, double y = 0, double r = 1)
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
    class User
    {
        private string name;
        private string secondname;
        private string surname;
        private DateTime birthday;
        private int age;
        public string Name { get { return name; } set { if (value.Length < 1) throw new ArgumentException("Недопустимая длина имени"); name = value; } }
        public string SecondName { get { return secondname; } set { if (value.Length < 1) throw new ArgumentException("Недопустимая длина отчества"); secondname = value; } }
        public string Surname { get { return surname; } set { if (value.Length < 1) throw new ArgumentException("Недопустимая длина фамилии"); surname = value; } }
        public DateTime Birthday { get { return birthday; } set { birthday = value; } }
        public int Age { get { return age= DateTime.Now.Year - birthday.Year; }  private set { age = value; } }
        public User() { }
        public User(string name, string secondname, string surname)
        {
            Name = name;
            SecondName = secondname;
            Surname = surname;          
        }
    }
    class Employee : User
    {
        
        private int duration;
        private string position;
        public int DurationOfWork { get { return duration; } set { if (value < 0) throw new ArgumentException("Значение должно быть положительным"); duration = value;  } }
        public string Position { get { return position; } set { if (value.Length < 1) throw new ArgumentException("Недопустимая длина должности"); position = value; } }
    }
    class Ring : Round
    {
        public Ring(double x=0, double y=0, double r=1, double r2=2):base(x,y,r)
        {
           OutsideRadius=r2;
        }
        private double outsideradius;
        public double OutsideRadius{set{if (value <= Radius)throw new ArgumentException("Значение внешнего радиуса должно быть больше внутреннего");outsideradius = value;}get { return outsideradius; }}
        public double OutsideCircumference { get { return 2 * PI * outsideradius; } }
        public double SumOfCircumference { get { return Circumference + OutsideCircumference; } }
        public double RingArea { get { return PI * (OutsideRadius * OutsideRadius - Radius * Radius); } }
    }
    

}

