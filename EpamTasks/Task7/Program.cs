using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Run();
        }
        public static void Run()
        {
            Console.WriteLine("Please, choose a task");
            Console.WriteLine("0: Exit");
            Console.WriteLine("1: Date Existance");
            Console.WriteLine("2: HTML Replacer");
            Console.WriteLine("3: Email Finder");
            Console.WriteLine("4: Number Validator");
            Console.WriteLine("5: Time Counter");
            int mode = Exception(Console.ReadLine());
            switch (mode)
            {
                case 0:
                    Environment.Exit(0);
                    break;
                case 1:
                    DateExistance();
                    Run();
                    break;
                case 2:
                    HtmlReplacer();
                    Run();
                    break;
                case 3:
                    EmailFinder();
                    Run();
                    break;
                case 4:
                    NumberValidator();
                    Run();
                    break;
                case 5:
                    TimeCounter();
                    Run();
                    break;
                default:
                    Console.WriteLine("Cannot find apropriate task, please check the input");
                    Run();
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
                    Console.WriteLine("Incorrect input");
                    result = Int32.TryParse(Console.ReadLine(), out x);
                }
                while (result == false);
            }
            return x;
        }
        public static void DateExistance()
        {
            Console.WriteLine("Please put a text ");
            string input = Console.ReadLine();
            Regex regex = new Regex(@"\d{1,2}-\d{1,2}-\d{4}");
            MatchCollection matches = regex.Matches(input);
            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                    Console.WriteLine(match.Value);
            }
            else { Console.WriteLine("No date"); }
        }
        public static void HtmlReplacer()
        {
            string input = "Введите текст: <b>Это</b>текст<i>c</i><font color=\"red\">HTML</font> кодами";
            string pattern = @"\<(/?[^\>]+)\>";
            string replacement = "_";
            string result = Regex.Replace(input, pattern, replacement);
            Console.WriteLine(result);
        }
        public static void EmailFinder()
        {
            Console.WriteLine("Please put a text ");
            string input = Console.ReadLine();
            Regex regex = new Regex(@"\w+([.-]\w+)*@\w+([.]\w+)*");
            MatchCollection matches = regex.Matches(input);
            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                    Console.WriteLine(match.Value);
            }
            else { Console.WriteLine("No Emails"); }
            string pattern = @"\w+([.-]\w+)*@\w+([.]\w+)*";
        }
        public static void NumberValidator()
        {
            Console.WriteLine("Please put a text ");
            string input = Console.ReadLine();
            string simple = @"(-\d+[.,]+\d+)|(\d+[.,]+\d+)|\d+";
            string scientific = @"(\d.+([=,.e-]+\d+))|\d.+[e]|\d+[e]";
            
             if (Regex.IsMatch(input, scientific))
            {
                Console.WriteLine("It's a scientific notaton");
            }
            else if (Regex.IsMatch(input, simple))
            {
                Console.WriteLine("It's a simple notation");
            }
            else 
            { 
                Console.WriteLine("Not number"); 
            }
        }
        public static void TimeCounter()
        {
            Console.WriteLine("Please put a text ");
            string input = Console.ReadLine();
            Regex regex = new Regex(@"\b(([0-9])|(0[0-9])|(1[0-9])|(2[0-3])):[0-5][0-9]\b");
            MatchCollection matches = regex.Matches(input);
            int i = 0;
            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                {
                    i++;                  
                }
                Console.WriteLine("Time has founded " +i);
            }
            else { Console.WriteLine("No time in text"); }
        }

    }
}
