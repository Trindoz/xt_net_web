using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Task3_1_2<T>
    {
        public static void Lost(IList<T> collection)
        {
            Console.WriteLine("Задание 3.1");
            foreach (T item in collection)
                Console.Write(item);
            bool x =false;
            int n = collection.Count;
            while (collection.Count>1)
            {
                
                for (int i = 0; i < collection.Count; i++)
                {
                   if (x) collection.RemoveAt(i--);
                   x = !x;
                }
                Console.WriteLine();
                foreach (T item in collection)
                    Console.Write(item);
            }  
        }
        public static void WordFreqeuncy(string input)
        {
            Console.WriteLine("Задание 3.2");
            Console.Write("Изначальный текст:");
            foreach (var s in input)
                Console.Write(s);
            Console.WriteLine();
            List<string> words = input.ToLower().Split(new char[] { ',', ' ','.' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var word = new Dictionary<string, int>();
            foreach (string i in words)
            {
                if (word.ContainsKey(i))
                    word[i]++;
               else word[i] = 1;
            }
            foreach (var item in word)
            {
                Console.WriteLine("Cлово {"+item.Key+"} встречается " + item.Value.ToString());
            }
           
        }
    }
}
