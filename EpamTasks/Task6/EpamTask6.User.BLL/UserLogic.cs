using System;
using System.Collections.Generic;
using Users.BLL.Interfaces;
using Users.Dao.Interfaces;
using Users.Entities;

namespace Users.BLL
{
    public class UserLogic : IUserLogic
    {
        private readonly IUserDao _userDao;
        public UserLogic(IUserDao userDao)
        {
            _userDao = userDao;
        }
        public User Add(User user)
        {
            return _userDao.Add(user);
        }

        public bool AddAward(int userid, Award award)
        {
            return _userDao.AddAward(userid, award);
        }

        public bool DeleteAward(int userid, Award award)
        {
            return _userDao.DeleteAward(userid, award);
        }

        public bool DeleteUser(int id)
        {
            return _userDao.DeleteUser(id);
        }

        public IEnumerable<User> GetAll()
        {
            return _userDao.GetAll();
        }

        public User GetById(int id)
        {
            return _userDao.GetById(id);
        }
    }
}
