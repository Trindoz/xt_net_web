using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task11.DAL.Interfaces;
using Task11.Entities;

namespace Task11.DAL
{
    public class UserDao:IUserDao
    {
        private string _connection = "Data Source=.;Initial Catalog=Users;Integrated Security=True";
        public int Add(User item) 
        {
            using(SqlConnection connection = new SqlConnection(_connection))
            {
                var command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "dbo.AddUser";
                    var nameParameter = new SqlParameter()
                    {
                        DbType = DbType.String,
                        ParameterName = "@Name",
                        Value = item.Name,
                        Direction = ParameterDirection.Input,
                    };
                command.Parameters.Add(nameParameter);         
                    var IdParameter = new SqlParameter()
                    {
                        DbType = DbType.Int32,
                        ParameterName = "@Id",
                        Value = item.Id,
                        Direction = ParameterDirection.Output,
                    };
                command.Parameters.Add(IdParameter);
                connection.Open();
                command.ExecuteNonQuery();
                return (int)IdParameter.Value;
            }
        }
        public User GetById(int id)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<User> GetAll()
        {
            var users = new List<User>();
            using (SqlConnection connection = new SqlConnection(_connection))
            {
                var command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT[id],[name] FROM[Users].[dbo].[Users]";
                connection.Open();
                var reader=command.ExecuteReader();
                while (reader.Read())
                {
                    users.Add(new User
                    {
                        Id = (int)reader["id"],
                        Name=reader["name"] as string,
                    });
                }
            }
            return users;
        }
    }
}
