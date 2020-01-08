using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Users.Dao.Interfaces;
using Users.Entities;

namespace Users.DAL
{
    public class AwardFakeDao : IAwardDao
    {
        private static string _path = @"C:\Users\ып\Desktop\Task6\awards.json";
        private static Dictionary<int, Award> _awards = new Dictionary<int, Award>();
        static AwardFakeDao()
        {
            if (File.Exists(_path))
            {
                string listofawards = File.ReadAllText(_path);
                _awards = JsonConvert.DeserializeObject<Dictionary<int, Award>>(listofawards);
            }
        }
        public Award Add(Award award)
        {
            var lastId = _awards.Keys.Count > 0 ? _awards.Keys.Max() : 0;
            award.Id = lastId + 1;
            _awards.Add(award.Id, award);
            Writing();
            return award;
        }

        public bool Delete(int id)
        {
            bool result = _awards.Remove(id);
            if (result)
                Writing();
            return result;
        }

        public IEnumerable<Award> GetAwards()
        {
            return _awards.Values;
        }
        public static void Writing()
        {
            string serialized = JsonConvert.SerializeObject(_awards);
            if (File.Exists(_path))
            {
                File.Delete(_path);
                File.AppendAllText(_path, serialized);
            }
            else File.AppendAllText(_path, serialized);
        }

        public Award GetById(int id)
        {
            _awards.TryGetValue(id, out var award);
            return award;
        }
    }
}
