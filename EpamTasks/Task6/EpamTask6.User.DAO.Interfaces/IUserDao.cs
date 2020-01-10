using System;
using System.Collections.Generic;
using System.Text;
using Users.Entities;

namespace Users.Dao.Interfaces
{
    public interface IUserDao
    {
        User Add(User user);
        bool DeleteUser(int id);
        User GetById(int id);
        IEnumerable<User> GetAll();      
        bool AddAward(int userid, Award award);
        bool DeleteAward(int userid, Award award);
    }
}
