using CS6920Group4Project.Model;
using CS6920Group4Project.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS6920Group4Project.Session
{
    /// <summary>
    /// This class contains session information
    /// </summary>
    public static class SessionInformation
    {
        /// <summary>
        /// This is the user who is currently signed in
        /// </summary>
        private static User SignedInUser;

        /// <summary>
        /// This is the budget the user has chosen to access
        /// </summary>
        private static Budget _Budget;

        /// <summary>
        /// The next to static variables are related to the MyBudgetForm's Session Labels.
        /// These two labels will display the username and income remaining for the application.
        /// If more labels are needed declare them here
        /// In order to refresh the view after values in _Budget are updated, 
        ///   call Session.SessionInformation.RefreshSessionLabels()
        /// </summary>
        private static Label _LBLUserName;
        private static Label _LBLIncomeRemaining;

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

        /// <summary>
        /// This function sets the current user's _Budget equal to budget
        /// </summary>
        /// <param name="budget">The budget the current user wishes to update</param>
        public static void SetCurrentBudget(Budget budget)
        {
            _Budget = budget;
        }

        /// <summary>
        /// Sets the UserName Session Label
        /// </summary>
        /// <param name="lblUserName">Label for the User's Name</param>
        public static void SetUserNameSessionLabel(Label lblUserName)
        {
            _LBLUserName = lblUserName;
        }

        /// <summary>
        /// Sets the IncomeRemaining Session Label
        /// </summary>
        /// <param name="lblIncomeRemaining">Label for the user's income remaining for the current budget</param>
        public static void SetIncomeRemainingSessionLabel(Label lblIncomeRemaining)
        {
            _LBLIncomeRemaining = lblIncomeRemaining;
        }

        /// <summary>
        /// This function refreshes the labels after a change is made
        /// </summary>
        public static void RefreshSessionLabels()
        {
            _LBLUserName.Text = Session.SessionInformation.GetSessionUser().FirstName
                + " " + Session.SessionInformation.GetSessionUser().LastName; ;
            _LBLIncomeRemaining.Text = StringUtilities.GetDisplayableDollarAmount(
                GetBudget().GetTotalAmountOfEarnings() - (GetBudget().GetTotalAmountOfBills() + GetBudget().GetTotalAmountOfExpenses()));
        }

        /// <summary>
        /// Initializes the Session
        /// </summary>
        public static void InitSession()
        {
            SignedInUser = new User();
            _Budget = new Budget();
            
            if (_LBLUserName != null)
                _LBLUserName = null;

            if (_LBLIncomeRemaining != null)
                _LBLIncomeRemaining = null;
        }
    }
}
