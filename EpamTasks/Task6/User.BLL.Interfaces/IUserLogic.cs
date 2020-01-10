using System;
using System.Collections.Generic;
using Users.Entities;

namespace Users.BLL.Interfaces
{
    public interface IUserLogic
    {
        User Add(User user);
        bool DeleteUser(int id);
        User GetById(int id);
        IEnumerable<User> GetAll();
        bool AddAward(int userid, Award award);
        bool DeleteAward(int userid, Award award);
        
    }
}
