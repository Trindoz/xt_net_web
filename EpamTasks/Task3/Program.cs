using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace Task3
{

    class Program
    {
        static void Main(string[] args)
        {
            List<int> lost= new List<int> { 1, 2, 3, 4,5,6,7,8,9,10,11,12,13,14,15,16 };          
            Task3_1_2<int>.Lost(lost);
            Console.WriteLine(); 
            Task3_1_2<string>.WordFreqeuncy("Anyone who reads Old and Middle English literary texts will be familiar with the mid-brown volumes of the EETS, with the symbol of Alfred's jewel embossed on the front cover. Most of the works attributed to King Alfred or to Aelfric, along with some of those by bishop Wulfstan and much anonymous prose and verse from the pre-Conquest period, are to be found within the Society's three series; all of the surviving medieval drama, most of the Middle English romances, much religious and secular prose and verse including the English works of John Gower, Thomas Hoccleve and most of Caxton's prints all find their place in the publications. Without EETS editions, study of medieval English texts would hardly be possible.");
            Console.WriteLine("Задание DynamicArray");
            int[] s = { 0, 1, 2, 3, 4, 5, 6, 7 };
            DynamicArray<int> my = new DynamicArray<int>(s);
            Console.Write("Первоначальный массив ");
            foreach (int i in my)
                Console.Write(i);
            Console.WriteLine();
            Console.WriteLine("Длина массива "+my.Length);
            Console.WriteLine("Емкость массива "+my.Capacity);
            Console.WriteLine("Обращение по индексу 3, значение равно "+my[3]);
            Console.WriteLine("Обращение по индексу -3, значение равно " + my[-3]);
            my.Add(8);
            Console.Write("Массив после добавления элемента ");
            foreach (int i in my)
                Console.Write(i);
            Console.WriteLine();
            Console.WriteLine("Длина массива после добавления элемента " + my.Length);
            Console.WriteLine("Емкость массива после добавления элемента " + my.Capacity);
            Console.Write("Массив после удаления элемента "+ my.Remove(5)+":");
            foreach (int i in my)
                Console.Write(i);
            Console.WriteLine();
            Console.WriteLine("Длина массива после удаления элемента " + my.Length);
            Console.WriteLine("Емкость массива после удаления элемента " + my.Capacity);        
            Console.Write("Массив после вставки элемента "+ my.Insert(5, 5)+":");
            foreach (int i in my)
                Console.Write(i);
            Console.WriteLine();
            Console.WriteLine("Длина массива после вставки элемента "+my.Length);
            Console.WriteLine("Емкость массива после вставки элемента "+my.Capacity);
            my.AddRange(new DynamicArray<int> { 9, 10, 11,12,13,14,15,16 });
            Console.Write("Массив после добавления коллекции ");
            foreach (int i in my)
                Console.Write(i);
            Console.WriteLine();         
            Console.WriteLine("Длина массива после добавления коллекции "+my.Length);
            Console.WriteLine("Емкость массива после добавления коллекции "+my.Capacity);
        }
    }     
}
