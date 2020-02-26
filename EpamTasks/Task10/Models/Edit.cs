using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HtmlAgilityPack;
using Fizzler.Systems.HtmlAgilityPack;
using Users.Ioc;
using Users.Entities;

namespace Task10.Models
{
    public class Edit
    {
       public User GetUser(int id)
        {
            User user = new User();
            var logic = DependencyResolver.UserLogic;
            user=logic.GetById(id);
            return user;
        }
    }
}