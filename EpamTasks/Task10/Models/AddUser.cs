using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Users.Entities;
using Users.Ioc;

namespace Task10.Models
{
    public static class AddUser
    {
       public static void Add()
        {
            var logic = DependencyResolver.UserLogic;
            logic.Add(new User());
        }
    }
}