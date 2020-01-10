using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Users.BLL;
using Users.Entities;
using Users.Ioc;


namespace Users.ConsolePL
{
    class Program
    {
        static void Main(string[] args)
        {

            Run();
        }
        public static void Run()
        {
            Console.WriteLine("Please, choose the mode");
            Console.WriteLine("0: Exit");
            Console.WriteLine("1: User");
            Console.WriteLine("2: Award");
            int mode = Exception(Console.ReadLine());
            switch (mode)
            {
                case 0:
                    Environment.Exit(0);
                    break;
                case 1:
                    User();
                    break;
                case 2:
                    Award();
                    break;
                default:
                    Console.WriteLine("Cannot find apropriate mode, please check a number");
                    Run();
                    break;
            }          
        }
        public static void User()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Please, choose the mode");
            Console.WriteLine("0: Exit");
            Console.WriteLine("1: Show Users");
            Console.WriteLine("2: Add User");
            Console.WriteLine("3: Delete User");
            Console.WriteLine("4: Add Award to user");
            Console.WriteLine("5: Delete Award from user");
            int mode = Exception(Console.ReadLine()); ;
            switch (mode)
            {
                case 0:
                    Run();
                    break;
                case 1:
                    {
                        ShowUsers();
                        User();
                        break;
                    }
                case 2:
                    {
                        AddUser();
                        User();
                        break;
                    }
                case 3:
                    {
                        DeleteUser();
                        User();
                        break;
                    }
                case 4:
                    {
                        AddAwardToUser();
                        User();
                        break;
                    }
                case 5:
                    {
                        DeleteAwardFromUser();
                        User();
                        break;
                    }
                default:
                    Console.WriteLine("Cannot find apropriate mode, please check a number");
                    User();
                    break;
            }
        }
        public static void Award()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Please, choose the mode");
            Console.WriteLine("0: Exit");
            Console.WriteLine("1: Show Awards");
            Console.WriteLine("2: Add Award");
            Console.WriteLine("3: Delete Award");
            int mode = Exception(Console.ReadLine());
            switch (mode)
            {
                case 0:
                    Run();
                    break;
                case 1:
                    ShowAwards();
                    Award();
                    break;
                case 2:
                    AddAwardToList();
                    Award();
                    break;
                case 3:
                    DeleteAwardFromList();
                    Award();
                    break;
                default:
                    Console.WriteLine("Cannot find apropriate mode, please check a number");
                    Award();
                    break;
            }
        }
        static void AddUser()
        {
            Console.WriteLine("Please, put the Name of a person");
            string name = Console.ReadLine();
            DateTime datevalue;
            Console.WriteLine("Ok, now we need the date of birthday. Be careful, the date need to be in year/month/day format");
            while (!DateTime.TryParse(Console.ReadLine(), out datevalue))
            {
                Console.WriteLine("Incorrect input");
                Console.WriteLine("Enter the date of birthday");
            }
            var logic = DependencyResolver.UserLogic;
            var currennt = logic.Add(new User()
            {
                Name = name,
                DateOfBirth = datevalue
            });            
            Console.WriteLine("New User has added!");
        }
        static void ShowUsers()
        {
            Console.ForegroundColor=ConsoleColor.Green;
            var logic = DependencyResolver.UserLogic;
                if(logic.GetAll().Count()==0) Console.WriteLine("The list of users is empty");
                foreach (var item in logic.GetAll())
                {
                    Console.WriteLine(item);
                }                  
        }
         static void DeleteUser()
        { 
            var logic = DependencyResolver.UserLogic;
            Console.WriteLine("Please enter Id of user to delete");
            int x;
            string s=Console.ReadLine();
            bool result = Int32.TryParse(s, out x);
            if (result&x>0&x<=logic.GetAll().Count()) ;
            else
            {
                do
                {              
                    Console.WriteLine("Incorect input");
                    result = Int32.TryParse(Console.ReadLine(), out x);
                }
                while (result == false|x<1|x>logic.GetAll().Count());
            }                     
            logic.DeleteUser(x);
        } 
        static void AddAwardToUser()
        {
            Console.WriteLine("Choose a user in a list below to add an award");
            ShowUsers();
            int userid = Exception(Console.ReadLine());
            Console.WriteLine("Choose an award in a list below to add to user");
            ShowAwards();
            int awardid = Exception(Console.ReadLine());
            var logicaward = DependencyResolver.AwardLogic;
            Award award= logicaward.GetById(awardid); 
            var logicuser = DependencyResolver.UserLogic;
            logicuser.AddAward(userid,award);            
        }
        static void DeleteAwardFromUser()
        {
            Console.WriteLine("Choose a user in a list below to delete an award");
            ShowUsers();
            int userid = Exception(Console.ReadLine());
            Console.WriteLine("Choose an award in a list below to delete from user");
            ShowAwards();
            int awardid = Exception(Console.ReadLine());
            var logicaward = DependencyResolver.AwardLogic;
            Award award = logicaward.GetById(awardid);
            var logicuser = DependencyResolver.UserLogic;
            logicuser.DeleteAward(userid, award);
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
        static void ShowAwards()
        {
            var logic = DependencyResolver.AwardLogic;
            if (logic.GetAwards().Count() == 0) Console.WriteLine("The list of awards is empty");
            foreach (var item in logic.GetAwards())
            {
                Console.WriteLine(item);
            }
        }
        static void AddAwardToList() 
        {
            Console.WriteLine("Please, put the Title of a Award");
            string name = Console.ReadLine();      
            var logic = DependencyResolver.AwardLogic;
            var currennt = logic.Add(new Award()
            {
                Title = name
            });
            Console.WriteLine("New award has added!");
        }      
        static void DeleteAwardFromList() 
        {
            var logic = DependencyResolver.AwardLogic;
            Console.WriteLine("Please enter Id of award to delete");
            int x;
            string s = Console.ReadLine();
            bool result = Int32.TryParse(s, out x);
            if (result & x > 0 & x <= logic.GetAwards().Count()) ;
            else
            {
                do
                {
                    Console.WriteLine("Incorect input");
                    result = Int32.TryParse(Console.ReadLine(), out x);
                }
                while (result == false | x < 1 | x > logic.GetAwards().Count());
            }
            logic.Delete(x);
        }

    }
}
