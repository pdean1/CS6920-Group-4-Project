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
        /// This statement allows a developer to insert a User into the Users table
        /// </summary> 
        private const String InsertUserStatement = "INSERT INTO `sql5123046`.`users` (`FirstName`, `LastName`, `UserName`, `Password`, `DateCreated`)" + 
            " VALUES (@FirstName, @LastName, @UserName, @Password, @DateCreated);";

        /// <summary>
        /// This function will add a user to the database. If this function encounters a MySQLException, 
        /// a message box is presented to the user informing them of the issue and the function will return 0
        /// </summary>
        /// <param name="user">The User to be added</param>
        /// <returns>0 on a failed insertion, or the ID of the last inserted record</returns>
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
                command.Parameters.AddWithValue("@FirstName", user.FirstName);
                command.Parameters.AddWithValue("@LastName", user.LastName);
                command.Parameters.AddWithValue("@UserName", user.UserName);
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



        public User LoginUser(String UserName, String Password)
        {
            throw new Exception("Functionality not yet implemented");

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
