using CS6920Group4Project.dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using CS6920Group4Project.model;
using System.Windows.Forms;
using CS6920Group4Project.Utilities;
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
        private const String InsertUserStatement = "INSERT INTO `sql5123046`.`users` (`FirstName`, `LastName`," + 
            " `UserName`, `Password`, `DateCreated`) VALUES (@FirstName, @LastName, @UserName, @Password, @DateCreated);";

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
                DatabaseErrorMessageUtility.SendMessageToUser("Problem adding user to the database.", exception);
                id = 0;
            }
            finally
            {
                conn.Close();
            }
            return id;
        }

        private const string LogInQuery = "SELECT `users`.`UserID`, `users`.`FirstName`, `users`.`LastName`, `users`.`UserName`," +
            " `users`.`Password`, `users`.`DateCreated`, `users`.`DateUpdated` FROM `sql5123046`.`users` WHERE `users`.`UserName`" + 
            " = @UserName AND `users`.`Password` = @Password;";

        /// <summary>
        /// Attempts to retrieve and log in a user based on the supplied credentials (username and password)
        /// </summary>
        /// <param name="UserName">The username of a user attempting to log in</param>
        /// <param name="Password">The password of a user attempting to log in</param>
        /// <returns>A populated user object or null</returns>
        public User AttemptUserLogin(String UserName, String Password)
        {
            User user = new User();
            try
            {
                MySqlCommand command = new MySqlCommand();
                conn.Open();
                command.Connection = conn;
                command.CommandText = LogInQuery;
                command.Prepare();
                command.Parameters.AddWithValue("@UserName", UserName);
                command.Parameters.AddWithValue("@Password", Password);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    for (int i = 0; reader.Read(); i++)
                    {
                        if (i > 0)
                        {
                            conn.Close();
                            return null;
                        }
                        user.ID = reader.GetInt32(0);
                        user.FirstName = reader.GetString(1);
                        user.LastName = reader.GetString(2);
                        user.UserName = reader.GetString(3);
                        user.Password = reader.GetString(4);
                        user.DateCreated = reader.GetDateTime(5);
                        try
                        {
                            user.DateUpdated = reader.GetDateTime(6);
                        }
                        catch (Exception)
                        {
                            user.DateUpdated = null;
                        }
                    }
                    conn.Close();
                    return user;
                }
            }
            catch (MySqlException e)
            {
                DatabaseErrorMessageUtility.SendMessageToUser("Unable to query for users in the database.", e);
                return null;
            }
            catch (Exception e)
            {
                MessageBox.Show("Unable to query for users in the database. Error information: " + e.Message + "\n" + e.StackTrace);
                return null;
            }
            finally 
            {
                conn.Close();
            }
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
