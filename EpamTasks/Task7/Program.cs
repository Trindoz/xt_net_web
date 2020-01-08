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
            DateExistance();
            HtmlReplacer();
            EmailFinder();
            NumberValidator();
        }
        public static void DateExistance()
        {
            string input = "Введите текст, содержащий дату в формате dd-mm-yyyy: 2016 год наступит 01-01-2016";
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
            string input = "Иван:ivan@mail.ru,Петр:p_ivanov@mail.rol.ru,Семен:54-Semen.zak-Harov@list.com";
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
    }
}
