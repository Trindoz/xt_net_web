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
        static void SelectTask()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1-Rectangle");
            Console.WriteLine("2-Triangle");
            Console.WriteLine("3-Another Triangle");
            Console.WriteLine("4-X-Mas Tree");
            Console.WriteLine("5-Sum of Numbers");
            Console.WriteLine("6-Font adjustment");
            Console.WriteLine("7-Array Processing");
            Console.WriteLine("8-No Positive");
            Console.WriteLine("9-Non-negative Sum");
            Console.WriteLine("10-2D Array");
            Console.WriteLine("11-Average String Length");
            Console.WriteLine("12-Char Doubler");
            Console.WriteLine("Выберите нужное задание: ");
            Console.WriteLine("Для выхода нажмите 0");
            int a = Exception(Console.ReadLine());
            switch (a)
            {
                case 0:
                    Environment.Exit(0);
                    break;
                case 1:
                    Console.WriteLine("Вы выбрали задание " + a);
                    Rectangle();
                    break;
                case 2:
                    Console.WriteLine("Вы выбрали задание " + a);
                    Triangle();
                    break;
                case 3:
                    Console.WriteLine("Вы выбрали задание " + a);
                    AnotherTriangle();
                    break;
                case 4:
                    Console.WriteLine("Вы выбрали задание " + a);
                    XMasTree();
                    break;
                case 5:
                    Console.WriteLine("Вы выбрали задание " + a);
                    SumOfNumbers();
                    break;
                case 6:
                    Console.WriteLine("Вы выбрали задание " + a);
                    FontAdjustment();
                    break;
                case 7:
                    Console.WriteLine("Вы выбрали задание " + a);
                    ArrayProcessing();
                    break;
                case 8:
                    Console.WriteLine("Вы выбрали задание " + a);
                    NoPositive();
                    break;
                case 9:
                    Console.WriteLine("Вы выбрали задание " + a);
                    NonNegativeSum();
                    break;
                case 10:
                    Console.WriteLine("Вы выбрали задание " + a);
                    SecondRangArray();
                    break;
                case 11:
                    Console.WriteLine("Вы выбрали задание " + a);
                    AverageStringLength();
                    break;
                case 12:
                    Console.WriteLine("Вы выбрали задание " + a);
                    CharDoubler();
                    break;

                default:
                    Console.WriteLine("Задания с выбранным номером не существует ");
                    Console.WriteLine("Введите номер задания ");
                    Exception(Console.ReadLine());
                    break;
            }

        }
        static void Rectangle()//Задание 1.1
        {
            Console.WriteLine("Введите сторону a");
            int a = Exception(Console.ReadLine());
            while (a < 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Вы ввели неккоректное значение");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Введите сторону a");
                a = Exception(Console.ReadLine());
            }
            Console.WriteLine("Введите сторону b");
            int b = Exception(Console.ReadLine());
            while (b < 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Вы ввели неккоректное значение");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Введите сторону b");
                b = Exception(Console.ReadLine());
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Площадь прямоугольника равна: " + a * b);
            SelectTask();
        }
        static void Triangle()//Задание 1.2
        {
            Console.WriteLine("Введите положительное число");
            int a = Exception(Console.ReadLine());
            while (a < 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Вы ввели неккоректное значение");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Введите положительное число");
                a = Exception(Console.ReadLine());
            }
            for (string star = ""; star.Length <= a; star += "*")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(star);
            }
            SelectTask();
        }
        static void AnotherTriangle()//Задание 1.3
        {
            Console.WriteLine("Введите положительное число");
            int a = Exception(Console.ReadLine());
            while (a < 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Вы ввели неккоректное значение");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Введите положительное число");
                a = Exception(Console.ReadLine());
            }
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a - i; j++)
                {
                    Console.ForegroundColor = ConsoleColor.Green;

                    Console.Write(" ");
                }
                for (int j = 0; j < 2 * i + 1; j++)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            SelectTask();
        }
        static void XMasTree()//Задание 1.4
        {
            Console.WriteLine("Введите положительное число");
            int a = Exception(Console.ReadLine());
            while (a < 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Вы ввели неккоректное значение");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Введите положительное число");
                a = Exception(Console.ReadLine());
            }
            for (int x = 0; x <= a; x++)
            {
                for (int i = 0; i < x; i++)
                {
                    for (int j = 0; j < a - i; j++)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(" ");
                    }
                    for (int j = 0; j < 2 * i + 1; j++)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            SelectTask();
        }
        static void SumOfNumbers()//Задание 1.5
        {
            int sum = 0;
            for (int i = 3; i < 1000; i++)
            {
                if ((i % 3 == 0) | (i % 5 == 0))
                    sum += i;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Сумма чисел от 0 до 1000 кратных 3 и 5 равна: "+sum);
            SelectTask();
        }
        static void FontAdjustment()//Задание 1.6
        {
            TextFormat tx = new TextFormat();
            tx = TextFormat.None;
            Console.WriteLine("Параметры надписи: " + tx);
            while (1>0)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Введите: {0} 1:Bold {0} 2:Italic {0} 3:Underline", Environment.NewLine);
                Console.WriteLine("Чтобы выйти нажмите 0");             
                int a = Exception(Console.ReadLine());
                if (a == 0)
                    SelectTask();
                while (a < 1 | a > 3)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Вы ввели значение вне диапазона");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Введите от 1 до 3");
                    a = Exception(Console.ReadLine());
                }
                if (a == 3)
                    a = 4;
                tx ^= (TextFormat)a;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Параметры надписи: " + tx);             
            }
        }
     [Flags]
        enum TextFormat
        {
            None,
            Bold=1,
            Italic=2,
            Underline=4
        }
        static void ArrayProcessing()//Задание 1.7
        {
            Console.WriteLine("Введите длину массива");
            int a = Exception(Console.ReadLine());
            while (a < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Длина массива не может быть отрицательной");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Введите длину массива");
                a = Exception(Console.ReadLine());
            }
            if (a == 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("В массиве нет элементов");
            }
            else
            {
                int[] array = new int[a];
                Random rand = new Random();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Неотсортированный массив: ");
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = rand.Next(-100, 100);
                    Console.Write(array[i] + ",");
                }
                Sort(array);
                Console.WriteLine();
                Console.Write("Отсортированный массив: ");
                foreach (int i in array)
                {
                    Console.Write(i + ",");
                }
                Console.WriteLine();
                Console.WriteLine("Минимальное значение: " + array[0]);
                Console.WriteLine("Максимальное значение: " + array[array.Length - 1]);
            }
            SelectTask();
        }
        static void Sort(int[] array)//Реализация сортировки одномерного массива из отборочного задания
        {
            int[] arr = new int[array.Length];
            int x;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        x = array[i];
                        array[i] = array[j];
                        array[j] = x;
                    }
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                arr[i] = array[i];
            }
        }
        static void NoPositive()//Задание 1.8
        {
            Console.WriteLine("Введите размерность первого измерения: ");
            int a = Exception(Console.ReadLine());
            while (a < 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Размерность должна быть положительной");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Введите размерность первого измерения: ");
                a = Exception(Console.ReadLine());
            }           
            Console.WriteLine("Введите размерность второго измерения: ");
            int b = Exception(Console.ReadLine());
            while (b < 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Размерность должна быть положительной");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Введите размерность второго измерения: ");
                b = Exception(Console.ReadLine());
            }          
            Console.WriteLine("Введите размерность третьего измерения: ");
            int c = Exception(Console.ReadLine());
            while (c < 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Размерность должна быть положительной");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Введите размерность третьего измерения: ");
                c = Exception(Console.ReadLine());
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Массив, заполненный случайными числами");
            Random rand = new Random();
            int [,,]array = new int[a,b,c];
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {               
                    for (int k = 0; k < c; k++)
                    {
                        array[i, j, k] = rand.Next(-100, 100);
                        Console.Write(array[i, j, k] + ",");                                
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Положительные элемента массива заменены на 0");
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    for (int k = 0; k < c; k++)
                    {                   
                        if (array[i, j, k] > 0)
                            array[i, j, k] = 0;
                        Console.Write(array[i, j, k] + ",");
                    }
                }
            }
            Console.WriteLine();
            SelectTask();
        }
        static void NonNegativeSum()//Задание 1.9
        {
            Console.WriteLine("Введите длину массива");
            int a = Exception(Console.ReadLine());
            while (a < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Длина массива не может быть отрицательной");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Введите длину массива");
                a = Exception(Console.ReadLine());
            }
            if (a == 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("В массиве нет элементов");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                int[] array = new int[a];
                Random rand = new Random();
                Console.WriteLine("Массив, заполненный случайными числами: ");
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = rand.Next(-100, 100);
                    Console.Write(array[i] + ",");
                }
                Console.WriteLine();
                Console.Write("Сумма неотрицательных элементов равна: ");
                int sum = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] > 0)
                        sum += array[i];
                }
                Console.WriteLine(sum);
            }
            SelectTask();
        }
        static void SecondRangArray()//Задание 1.10
        {
            Console.WriteLine("Введите размерность первого измерения: ");
            int a = Exception(Console.ReadLine());
            while (a < 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Размерность должна быть положительной");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Введите размерность первого измерения: ");
                a = Exception(Console.ReadLine());
            }
            Console.WriteLine("Введите размерность второго измерения: ");
            int b = Exception(Console.ReadLine());
            while (b < 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Размерность должна быть положительной");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Введите размерность второго измерения: ");
                b = Exception(Console.ReadLine());
            }
            Console.ForegroundColor = ConsoleColor.Green;
           
            int[,] array = new int[a, b];
            Random rand = new Random();
            int sum = 0;
            Console.Write("Двумерный массив,заполненный случайными числами: ");
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {                 
                        array[i, j] = rand.Next(-100, 100);
                    if ((i + j) % 2 == 0) 
                        sum += array[i, j];
                    Console.Write(array[i, j] + ",");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Сумма элементов массива, стоящих на нечетной позиции равна: "+sum);
            
            SelectTask();
        }
        static void AverageStringLength()//Задание 1.11
        {
            Console.WriteLine("Введите несколько слов");
            string s = Console.ReadLine();
            if (s.Length == 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("В строке ничего нет");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                double sum_of_words = 1;
                if (!char.IsLetter(s, 0))
                    sum_of_words = 0;
                for (int i = 0; i < s.Length - 1; i++)
                {
                    if (!char.IsLetter(s, i))
                    {
                        sum_of_words++;
                        if (!char.IsLetter(s, i + 1))
                            sum_of_words--;
                    }
                }
                Console.WriteLine("Колличество слов: " + sum_of_words);
                char[] words = s.ToCharArray();
                double length_of_chars = 0;
                for (int i = 0; i < words.Length; i++)
                {
                    if (char.IsLetter(words[i]))
                        length_of_chars++;
                }
                Console.WriteLine("Колличество символов: " + length_of_chars);
                if (length_of_chars == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Нельзя определить среднюю длину слова, так как число символов равно нулю");
                }
                else
                {
                    Console.WriteLine("Средняя длина слова: " + length_of_chars / sum_of_words);
                }
            }
            SelectTask();
        }
        static void CharDoubler()//Задание 1.12
        {
            Console.WriteLine("Введите первую строку");
            string first = Console.ReadLine();
            Console.WriteLine("Введите вторую строку");
            string second = Console.ReadLine();
            second = new string(second.Distinct().ToArray());//метод удаляющий повторяющиеся символы
             Console.ForegroundColor = ConsoleColor.Green;
            char[] f = first.ToCharArray();
            char[] s = second.ToCharArray();
            for (int i = 0; i < f.Length; i++)
            {
                Console.Write(f[i]);
                for (int j = 0; j < s.Length; j++)
                {                   
                    if (f[i] == s[j])
                    {
                        Console.Write(f[i]);
                    }
                }
            }            
            Console.WriteLine();
            SelectTask();
        }
    }
}
