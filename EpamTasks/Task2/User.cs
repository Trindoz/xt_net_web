using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class User
    {
        private string name;
        private string secondname;
        private string surname;
        private DateTime birthday;
        private int age;
        public string Name { get { return name; } set { if (value.Length < 1) throw new ArgumentException("Недопустимая длина имени"); name = value; } }
        public string SecondName { get { return secondname; } set { if (value.Length < 1) throw new ArgumentException("Недопустимая длина отчества"); secondname = value; } }
        public string Surname { get { return surname; } set { if (value.Length < 1) throw new ArgumentException("Недопустимая длина фамилии"); surname = value; } }
        public DateTime Birthday { get { return birthday; } set { birthday = value; } }
        public int Age { get { return age = DateTime.Now.Year - birthday.Year; } private set { age = value; } }
        public User() { }
        public User(string name, string secondname, string surname)
        {
            Name = name;
            SecondName = secondname;
            Surname = surname;
        }
    }
    class Employee : User
    {

        private int duration;
        private string position;
        public int DurationOfWork { get { return duration; } set { if (value < 0) throw new ArgumentException("Значение должно быть положительным"); duration = value; } }
        public string Position { get { return position; } set { if (value.Length < 1) throw new ArgumentException("Недопустимая длина должности"); position = value; } }
    }
}
