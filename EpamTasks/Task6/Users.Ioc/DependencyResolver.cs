using System;
using Users.BLL;
using Users.BLL.Interfaces;
using Users.DAL;
using Users.Dao.Interfaces;

namespace Users.Ioc
{
    public static class DependencyResolver
    {
        private static IUserDao _userDao;
        public static IUserDao UserDao => _userDao ?? (_userDao = new UserFakeDao());
        private static IUserLogic _userLogic;
        public static IUserLogic UserLogic =>_userLogic??(_userLogic= new UserLogic(UserDao));
        private static IAwardDao _awardDao;
        public static IAwardDao AwardDao => _awardDao ?? (_awardDao = new AwardFakeDao());
        private static IAwardLogic _awardLogic;
        public static IAwardLogic AwardLogic => _awardLogic ?? (_awardLogic = new AwardLogic(AwardDao));
    }
}
