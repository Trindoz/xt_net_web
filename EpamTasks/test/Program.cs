using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace Task02_Triangle

{
    class Program
    {
        static void Main(string[] args)
        {

          

            Triangle b = new Triangle(1, 2, 3);
            b.A = 6;
            b.B = 2;
            b.C = 2;
           
        }
    }

    public class Triangle

    {

        private double a;

        private double b;

        private double c;



        public double A

        {

            get => a;

            set

            {

                if (value > 0)

                {

                    if (B != 0 && C != 0)

                    {

                        if (value < B + C && B < value + C && C < value + B)

                        {

                            a = value;

                        }

                        else

                        {

                            throw new ArgumentException("Wrong triangle!");

                        }

                    }

                }

                else

                {

                    throw new ArgumentException("Enter positive value for a:");

                }

            }

        }



        public double B

        {

            get => b;

            set

            {

                if (value > 0)

                {

                    if (A != 0 && C != 0)

                    {

                        if (value < A + C && A < value + C && C < value + A)

                        {

                            b = value;

                        }

                        else

                        {

                            throw new ArgumentException("Wrong triangle!");

                        }

                    }

                }

                else

                {

                    throw new ArgumentException("Enter positive value for b:");

                }

            }

        }



        public double C

        {

            get => c;

            set

            {

                if (value > 0)

                {

                    if (B != 0 && A != 0)

                    {

                        if (value < B + A && B < value + A && A < value + B)

                        {

                            c = value;

                        }

                        else

                        {

                            throw new ArgumentException("Wrong triangle!");

                        }

                    }

                }

                else

                {

                    throw new ArgumentException("Enter positive value for c:");

                }

            }

        }



        public Triangle() { }



        public Triangle(double a, double b, double c)

        {

            A = a;

            B = b;

            C = c;

        }



        public double Square => Math.Sqrt(HalfPerimeter * (HalfPerimeter - A) * (HalfPerimeter - B) * (HalfPerimeter - C));



        public double Perimeter => A + B + C;



        public double HalfPerimeter => Perimeter / 2;



        public void Show() => Console.WriteLine($"A = {A}, B = {B}, C = {C}, Square = {Square}, Perimeter = {Perimeter}");



        public static Triangle ReadTriangle()

        {

            Triangle tr;

            while (true)

            {

                Console.WriteLine("Enter digit of the a side.");

                if (double.TryParse(Console.ReadLine(), out double a))

                {

                    Console.WriteLine("Enter digit of the b side.");

                    if (double.TryParse(Console.ReadLine(), out double b))

                    {

                        Console.WriteLine("Enter digit of the c side.");

                        if (double.TryParse(Console.ReadLine(), out double c))

                        {

                            tr = new Triangle(a, b, c);

                            break;

                        }

                    }

                }

            }

            return tr;

        }

    }

}