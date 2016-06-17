using CS6920Group4Project.dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using CS6920Group4Project.model;
namespace CS6920Group4Project.DAL.Model
{
    public class UserDAL
    {
        /// <summary>
        /// This is the connection to open
        /// </summary>
        private MySqlConnection conn = new DBConnect().GetConnection();

        private const String InsertUserStatement = "INSERT INTO `sql5123046`.`users` (`Email`, `Password`, `DateCreated`)" + 
            " VALUES (@Email, @Password, @DateCreated);";

        public long InsertUser(User user)
        {
            MySqlCommand command = new MySqlCommand();
            command.Connection = conn;
            command.CommandText = InsertUserStatement;
            command.Prepare();
            command.Parameters.AddWithValue("@Email", user.Email);
            command.Parameters.AddWithValue("@Password", user.Password);
            command.Parameters.AddWithValue("@DateCreated", String.Format("yyyy-MM-dd", DateTime.Now));
            command.ExecuteNonQuery();
            return command.LastInsertedId;
        }
    }
}
