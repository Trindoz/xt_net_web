using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Users.Dao.Interfaces;
using Users.Entities;


namespace Users.DAL
{
    
    public class UserFakeDao : IUserDao
    {
        private static string _path = @"C:\Users\ып\Desktop\Task6\users.json";
        private static readonly Dictionary<int, User> _user = new Dictionary<int, User>();
        private static List<Award> _award = new List<Award>();
        static UserFakeDao()
        {
            if (File.Exists(_path))
            {
                string listofusers = File.ReadAllText(_path);
                _user = JsonConvert.DeserializeObject<Dictionary<int,User>>(listofusers);
            }
        }
        public User Add(User user)
        {
            var lastId = _user.Keys.Count > 0 ? _user.Keys.Max() : 0;
            user.Id = lastId + 1;
            _user.Add(user.Id, user);
            Writing();
            return user;
        }
        public bool AddAward(int userid, Award award)
        {
            User user=GetById(userid);
            _award.Add(award);
            user.Award=_award;
            Writing();          
            return true;
        }
        public bool DeleteUser(int id)
        {
            bool result =_user.Remove(id);
            if (result)
                Writing();
            return result;
        }
  
        public IEnumerable<User> GetAll()
        {
           
            return _user.Values;
        }
        public User GetById(int id)
        {
            _user.TryGetValue(id, out var user);
            return user;
        }
        
        public static void Writing()
        {           
            string serialized = JsonConvert.SerializeObject(_user);
            if (File.Exists(_path))
            {
                File.Delete(_path);
                File.AppendAllText(_path, serialized);
            }
            else File.AppendAllText(_path, serialized);
        }

        public bool DeleteAward(int userid, Award award)
        {
            User user = GetById(userid);
            _award.Remove(award);
            user.Award = _award;
            Writing();
            return true;
        }
    }
}
