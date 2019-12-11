using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] text = { "AABB ", "A ", "BB ", "CAB ", "BBAA ", "CFBD " };
            Console.WriteLine("Original text ");
            foreach (var item in text)
                Console.Write(item);
            Console.WriteLine();
            Class1<string>.CustomSort(text, Class1<string>.CompareString);
            Console.WriteLine("The text after sorting ");
            foreach (var item in text)
                Console.Write(item);
            Console.WriteLine();
            Console.WriteLine(Class1<int>.NumberArraySum(new int[] { 2, 2, 3, 4, 5 }));
            Console.WriteLine(Class1<string>.ToIntOrNotToInt("1"));



        }

    }
}
