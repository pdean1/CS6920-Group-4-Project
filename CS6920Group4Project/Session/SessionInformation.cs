using CS6920Group4Project.Model;
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

        private static Budget _Budget;

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

        /// <summary>
        /// Returns the list of budgets this user has
        /// </summary>
        /// <returns>the list of budgets this user has</returns>
        public static Budget GetBudget()
        {
            return _Budget;
        }

        public static void SetCurrentBudget(Budget budget)
        {
            _Budget = budget;
        }

        /// <summary>
        /// Initializes the Session
        /// </summary>
        public static void InitSession()
        {
            SignedInUser = new User();
            _Budget = new Budget();
        }
    }
}
