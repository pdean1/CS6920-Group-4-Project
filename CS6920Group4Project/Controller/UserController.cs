using CS6920Group4Project.DAL.Model;
using CS6920Group4Project.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS6920Group4Project.Controller
{
    /// <summary>
    /// This class controls access to the model classes and the database
    /// </summary>
    public class UserController : User
    {
        private static UserController instance;
        
        private readonly UserDAL userDAL = new UserDAL();

        private UserController()
        {

        }

        public static UserController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UserController();
                }
                return instance;
            }
        }

        /// <summary>
        /// Inserts a user, u, into the database
        /// </summary>
        /// <param name="u">User to insert</param>
        /// <returns>The id of the inserted record, or false</returns>
        public long InsertUser(User u)
        {
            return userDAL.InsertUser(u);
        }

        /// <summary>
        /// Attempts to log the user in. If successful the Session is set
        /// </summary>
        /// <param name="username">Username of the user to log in</param>
        /// <param name="password">the password of the user to log in</param>
        /// <returns>True if session was set false otherwise</returns>
        public Boolean Login(string username, string password)
        {
            User u = new User();
            u = userDAL.AttemptUserLogin(username, password);
            if (u == null)
                return false;
            Session.SessionInformation.SetSessionUser(u);
            return true;
        }
    }
}
