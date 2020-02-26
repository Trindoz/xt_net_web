using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task11.BLL;
using Task11.BLL.Interfaces;
using Task11.DAL;
using Task11.DAL.Interfaces;

namespace Task11.User.Ioc
{
    public static class UserIoc
    {
        public static IUserDao UserDao { get; set; } = new UserDao();
        public static IUserLogic UserLogic { get; set; } = new UserLogic(UserDao);
    }
}
