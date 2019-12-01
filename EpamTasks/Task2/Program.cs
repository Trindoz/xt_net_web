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
            SelectTask();
        }
        static void SelectTask()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Выберите заданаие");
            Console.WriteLine("1-Round");
            Console.WriteLine("2-Triangle");
            Console.WriteLine("3-User");
            Console.WriteLine("4-Vector Graphics Editor");
            Console.WriteLine("Для выхода нажмите 0");
            int a = Exception(Console.ReadLine());
            switch (a)
            {
                case 0:
                    Environment.Exit(0);
                    break;
                case 1:
                    Console.WriteLine("Вы выбрали задание " + a);
                    Round round = new Round();
                    round.X = 5;
                    round.Y = 7;
                    round.Radius = 3;
                    Console.WriteLine("Кординаты центра круга: " + round.X + " " + round.Y);
                    Console.WriteLine("Радиус: " + round.Radius);
                    Console.WriteLine("Длина окружности: " + round.Length);
                    Console.WriteLine("Площадь круга: " + round.Area);
                    Console.WriteLine();
                    SelectTask();
                    break;
                case 2:
                    Console.WriteLine("Вы выбрали задание " + a);
                    Triangle triangle = new Triangle(3, 2, 3);
                    Console.WriteLine("Периметр треугольника: " + triangle.TrianglePerimetr);
                    Console.WriteLine("Площадь треугольника: " + triangle.TriangleArea);
                    Console.WriteLine();
                    SelectTask();
                    break;
                case 3:
                    Console.WriteLine("Вы выбрали задание " + a);
                    User user = new User("Иван", "Иванович", "Иванов");
                    user.Birthday = new DateTime(1990, 01, 01);
                    Console.WriteLine(user.Name + " " + user.SecondName + " " + user.Surname + " " + user.Birthday + " " + user.Age);
                    Console.WriteLine();
                    SelectTask();
                    break;
                case 4:
                    Console.WriteLine("Вы выбрали задание " + a);
                    Console.WriteLine("Выберите фигуру");
                    Console.WriteLine("1-Line");
                    Console.WriteLine("2-Circumference");
                    Console.WriteLine("3-Rectangle");
                    Console.WriteLine("4-Round");
                    Console.WriteLine("5-Ring");
                    Console.WriteLine("Для выхода нажмите 0");

                    int b= Exception(Console.ReadLine());
                    switch (b)
                    {
                        case 0:
                            SelectTask();
                            break;
                        case 1:
                            Console.WriteLine("Вы выбрали Line");
                            Line line = new Line();
                            line.X = 1;
                            line.Y = 3;
                            line.X1 = 3;
                            line.Y1 = 3;
                            Console.WriteLine("Координаты точек для посторения линий: " + line.X + "," + line.Y + ";" + line.X1 + "," + line.Y1);
                            Console.WriteLine("Длина линии: "+line.Length);
                            Console.WriteLine();
                            break;
                        case 2:
                            Console.WriteLine("Вы выбрали Circumference");
                            Circumferece circumferece = new Circumferece();
                            circumferece.X = 1;
                            circumferece.Y = 2;
                            circumferece.Radius = 5;
                            Console.WriteLine("Координаты центра" + circumferece.X + ","+circumferece.Y);
                            Console.WriteLine("Радиус: " + circumferece.Radius);
                            Console.WriteLine("Длина окружности: "+circumferece.Length);
                            Console.WriteLine();
                            break;
                        case 3:
                            Console.WriteLine("Вы выбрали Rectangle");
                            Rectangle rectangle = new Rectangle(1, 1, 3, 4);
                            Console.WriteLine("Первоначальная точка прямоугольника  :"+rectangle.X+","+rectangle.Y);
                            Console.WriteLine("Длина: " + rectangle.Height);
                            Console.WriteLine("Ширина: " + rectangle.Width);
                            Console.WriteLine();
                            break;
                        case 4:
                            Console.WriteLine("Вы выбрали Round");
                            Round r = new Round(3,2,5);
                            Console.WriteLine("Кординаты центра круга: " + r.X + "," + r.Y);
                            Console.WriteLine("Радиус: " + r.Radius);
                            Console.WriteLine("Длина окружности: " + r.Length);
                            Console.WriteLine("Площадь круга: " + r.Area);
                            Console.WriteLine();
                            break;
                        case 5:
                            Console.WriteLine("Вы выбрали Ring");
                            Ring ring = new Ring();
                            ring.X = 3;
                            ring.Y = 4;
                            ring.Radius = 3;
                            ring.OutsideRadius = 4;
                            Console.WriteLine("Кординаты центра кольца: " + ring.X + "," + ring.Y);
                            Console.WriteLine("Внутрений радиус: " + ring.Radius);
                            Console.WriteLine("Внешний радиус: " + ring.OutsideRadius);
                            Console.WriteLine("Длина внутренней окружности: " + ring.Length);
                            Console.WriteLine("Длина внешней окружности: " + ring.OutsideCircumference);
                            Console.WriteLine("Сумма двух окружностей:" + ring.SumOfCircumference);
                            Console.WriteLine("Площадь кольца: " + ring.Area);
                            Console.WriteLine();
                            break;                       
                        default:
                            Console.WriteLine("Задания с выбранным номером не существует ");
                            Console.WriteLine();
                            break;
                    }
                    goto case 4;
                case 5:
                    Console.WriteLine("Выберите фигуру");
                    Console.WriteLine("1-Line");
                    Console.WriteLine("2-Circumference");
                    Console.WriteLine("3-Rectangle");
                    Console.WriteLine("4-Round");
                    Console.WriteLine("5-Ring");
                    b = Exception(Console.ReadLine());
                    break;               
                default:
                    Console.WriteLine("Задания с выбранным номером не существует ");
                    Console.WriteLine("Введите номер задания ");
                    Exception(Console.ReadLine());
                    break;
            }
        }
        static int Exception(string s)
        {
            int x;
            bool result = Int32.TryParse(s, out x);
            if (result) ;
            else
            {
                do
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Неверный формат");
                    Console.ForegroundColor = ConsoleColor.White;
                    result = Int32.TryParse(Console.ReadLine(), out x);
                }
                while (result == false);
            }
            return x;
        }
    }    
}

