using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task4
{
    delegate void MyEventHandler();
    delegate void Status(string s);
    class MyThread
    {    
        public Thread thread;
        public MyThread() { }

        public MyThread(string name)
        {
            thread = new Thread(Run);
            thread.Name = name;
            thread.Start();
        }
        void Run()
        {
            Console.WriteLine("We are starting a new thread: " + thread.Name);
            SortingInThread();
        }
        public void SortingInThread()
        {
            MyThread status = new MyThread();         
            Status show= new Status(Display);
            show("Words  before sorting: ");
            string[] words = { "AABB ", "A ", "BB ", "CAB ", "BBAA ", "CFBD " };
            foreach (var item in words)
                show(item);
            show(null);
            MyClass.CustomSort(words, MyClass.CompareString);
            show("We are starting to sort something, please, wait a few seconds......");
            Thread.Sleep(500);
            show(null);
            show("Words after sorting: ");
            foreach (var item in words)
                show(item);
            show(null);
            status.SomeEvent+=DisplayStatus;
            status.OnSomeEvent();
        }

        public event MyEventHandler SomeEvent;
        public void OnSomeEvent()
        {
            if (SomeEvent != null)
                SomeEvent();
        }
        public void DisplayEmptyLine()
        {
            Console.WriteLine();
        }
        public void DisplayStatus()
        {  
            Console.WriteLine("Sorting has finished!");  
        }
        public void Display(string s)
        {
            if (s == null) Console.WriteLine();
            Console.Write(s);
        }
    }
}
