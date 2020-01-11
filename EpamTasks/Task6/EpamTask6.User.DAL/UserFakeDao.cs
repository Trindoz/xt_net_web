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
        public bool AddAward(int userid, Award award)
        {
            List<Award> awards;
            User user = GetById(userid);
            if (user.Award == null)
            {
                awards = new List<Award>();
                awards.Add(award);
                user.Award = awards;
                return true;
            }
            else
            {
                awards = user.Award;
                foreach (var item in awards)
                {
                    if (item == award) 
                    return false;
                }
                awards.Add(award);
                user.Award = awards;
                Writing();
                return true;
            }
        }
        public bool DeleteAward(int userid, Award award)
        {         
            List<Award> awards;
            User user = GetById(userid);
            awards = user.Award;
            var itemToRemove = awards.SingleOrDefault(r => r.Id == award.Id);
                if (itemToRemove != null)
                    awards.Remove(itemToRemove);
            user.Award = awards;
            Writing();
                return true;
          
            
        }
    }
}
