using CS6920Group4Project.dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using CS6920Group4Project.model;
using System.Windows.Forms;
namespace CS6920Group4Project.DAL.Model
{
    public class UserDAL
    {
        /// <summary>
        /// This is the connection to open
        /// </summary>
        private MySqlConnection conn = new DBConnect().GetConnection();

        /// <summary>
        /// 
        /// </summary>
        private const String InsertUserStatement = "INSERT INTO `sql5123046`.`users` (`Email`, `Password`, `DateCreated`)" + 
            " VALUES (@Email, @Password, @DateCreated);";

        /// <summary>
        /// 
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public long InsertUser(User user)
        {
            long id = 0; 
            try
            {
                MySqlCommand command = new MySqlCommand();
                conn.Open();
                command.Connection = conn;
                command.CommandText = InsertUserStatement;
                command.Prepare();
                command.Parameters.AddWithValue("@Email", user.Email);
                command.Parameters.AddWithValue("@Password", user.Password);
                command.Parameters.AddWithValue("@DateCreated", DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));
                command.ExecuteNonQuery();
                id = command.LastInsertedId;
            }
            catch (MySqlException exception)
            {
                MessageBox.Show("Problem adding user to the database.\nMySQL Error Number: " + 
                    exception.Number + "\nMySQL Error Text: " + exception.Message);
                id = 0;
            }
            finally
            {
                conn.Close();
            }
            return id;
        }

        private const String DeleteUserStatement = "";

        public long DeleteUser(User user)
        {
            throw new Exception("Function not yet implemented.");
        }

        public long DeleteUser(long id)
        {
            throw new Exception("Function not yet implemented.");
        }

        private const String UpdateUserStatement = "";

        public long UpdateUser(User user)
        {
            throw new Exception("Function not yet implemented.");
        }
    }
}
