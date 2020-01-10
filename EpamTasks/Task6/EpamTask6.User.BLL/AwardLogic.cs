using System;
using System.Collections.Generic;
using System.Text;
using Users.BLL.Interfaces;
using Users.Dao.Interfaces;
using Users.Entities;

namespace Users.BLL
{
    public class AwardLogic : IAwardLogic
    {
        private readonly IAwardDao _awardDao;
        public AwardLogic(IAwardDao awardDao)
        {
            _awardDao = awardDao;
        }
        public Award Add(Award award)
        {
            return _awardDao.Add(award);
        }

        public bool Delete(int id)
        {
            return _awardDao.Delete(id);
        }

        public IEnumerable<Award> GetAwards()
        {
            return _awardDao.GetAwards();
        }

        public Award GetById(int id)
        {
            return _awardDao.GetById(id);
        }
    }
}
