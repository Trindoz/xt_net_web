using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task11.Entities;

namespace Task11.BLL.Interfaces
{
    public interface IUserLogic
    {
        int Add(User item);
        User GetById(int id);
        IEnumerable<User> GetAll();
    }
}
