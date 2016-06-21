using CS6920Group4Project.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS6920Group4Project.Session
{
    /// <summary>
    /// This class contains session information
    /// </summary>
    public static class SessionInformation
    {
        private static User SignedInUser;

        /// <summary>
        /// Retrieves the session user from session
        /// </summary>
        /// <returns>The session user</returns>
        public static User GetSessionUser()
        {
            return SignedInUser;
        }

        /// <summary>
        /// Sets the session user
        /// </summary>
        /// <param name="u">The user to set the session user to</param>
        public static void SetSessionUser(User u)
        {
            SignedInUser = u;
        }
    }
}
