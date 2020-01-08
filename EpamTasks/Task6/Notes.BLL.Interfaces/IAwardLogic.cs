using System;
using System.Collections.Generic;
using System.Text;
using Users.Entities;

namespace Users.BLL.Interfaces
{
    public interface IAwardLogic
    {
        Award Add(Award award);
        bool Delete(int id);
        Award GetById(int id);
        IEnumerable<Award> GetAwards();
    }
}
