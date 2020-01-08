using Notes.BLL;
using Notes.Entities;
using Notes.Ioc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.ConsolePL
{
    class Program
    {
        static void Main(string[] args)
        {
            var logic = DependencyResolver.NoteLogic;
            var  current=logic.Add(new Note()
            {
                Text = "Ivan Ivanov",
            }) ;
            foreach(var item in logic.GetAll())
            {
                Console.WriteLine(item);
            }
        }
    }
}
