using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task4
{
    class MyThread
    {     
        public Thread thread;
        public MyThread(string name)
        {
            thread = new Thread(Run);
            thread.Name = name;
            thread.Start();
        }
        void Run()
        {
            Console.WriteLine("We are starting a new thread: "+thread.Name);         
            SortingInThread();
        }
        public static void SortingInThread()
        {
            Action<string> show = Display;
            Action empty_line = DisplayEmptyLine;
            Action status = DisplayStatus;
            show("Words  before sorting: ");
            string[] words = { "AABB ", "A ", "BB ", "CAB ", "BBAA ", "CFBD " };
            foreach (var item in words)
                show(item);
            empty_line();
            MyClass.CustomSort(words, MyClass.CompareString);
            show("We are starting to sort something, please, wait a few seconds......");
            Thread.Sleep(5000);
            empty_line();
            show("Words after sorting: ");
            foreach (var item in words)
                show(item);
            empty_line();
            status();
        }
        public static void DisplayEmptyLine()
        {
            Console.WriteLine();
        }
        public static void DisplayStatus()
        {
            Console.WriteLine("Sorting has finished!");
        }
        public static void Display(string s)
        {
            Console.Write(s);
        }
    }
}
