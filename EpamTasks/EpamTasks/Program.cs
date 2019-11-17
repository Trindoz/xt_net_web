using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpamTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое положительное число: ");
            Sequence(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine();
            Console.Write("Введите целое положительное число: ");
            Simple(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine();
            Console.Write("Введите размер стороны желаемого квадрата: ");
            Square(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine();
            Console.Write("Введите размерность массива: ");
            Array(Convert.ToInt32(Console.ReadLine()));
        }
        static void Sequence(int a)//Задание 1
        {
            int[] numbers = new int[a + 1];
            int i = 1;
            Console.Write(i);
            for (i = 2; i < numbers.Length; i++)
            {
                Console.Write("," + i);
            }
        }
        static void Simple(int b)//Задание 2 
        {
            if (b == 1) Console.WriteLine(b + " ни простое ни составное число");
            else
            {
                for (int i = 2; i <= b / 2; i++)
                {
                    if (b % i == 0)
                        Console.WriteLine(b + " составное число ");
                }
                Console.WriteLine(b + " простое число");
            }
        }
        static void Square(int c)//Задание 3
        {
            int[,] stars = new int[c, c];
            if (c % 2 == 0)
            {
                for (int i = 0; i < stars.Length; i++)
                {
                    if (i % c == 0)
                        Console.WriteLine();
                    Console.Write("*");
                }
            }
            else
                for (int i = 0; i < stars.Length; i++)
                {
                    if (i % c == 0)
                    {
                        Console.WriteLine();
                    }
                    if (i == stars.Length / 2)
                    {
                        Console.Write(" ");
                        i++;
                    }
                    Console.Write("*");
                }
        }
        static void Array(int a)//Задание 4
        {
            int[][] array = new int[a][];
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Введите число элементов по размерности: " + i + ": ");
                array[i] = new int[Convert.ToInt32(Console.ReadLine())];
                for (int j = 0; j < array[i].Length; j++)
                {
                    array[i][j] = rand.Next(-100, 100);
                }
            }
            Console.WriteLine("Неотсортированный массив: ");
            Show(array);
            Sort(array);
            Console.WriteLine("Отсортрованный массив: ");
            Show(array);

        }
        static void Show(int[][] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{");
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j] + ",");
                }
                Console.Write("}");
                Console.WriteLine();
            }
        }
        static void Sort(int[][] array)//Сортровка двумерного массива
        {
            for (int i = 0; i < array.Length; i++)
            {
                Sort2(array[i]);
            }
        }
        static void Sort2(int[] array)//Реализация сортировки одномерного массива из отборочного задания
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
    }
}

