using System;
using System.Collections.Generic;

namespace Users.Entities
{
    public class User
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Age
        {
            get
            {
                var now = DateTime.Today;
                int age = now.Year - DateOfBirth.Year;
                if (DateOfBirth > now.AddYears(-age)) age--;
                return age;
            }
            private set { }
        }

        public List<Award> Award { get; set; }   
        public override string ToString()
        {
            Console.WriteLine($"{Id} {Name} {DateOfBirth.ToShortDateString()} {Age} ");
            Console.Write("Awards:");
            if (Award == null)
            {
                Console.WriteLine("no awards");
            }

            else
            {
                foreach (var item in Award)
                    Console.Write(item.Title + " ");
            }
            return "";
            
        }

    }
}
