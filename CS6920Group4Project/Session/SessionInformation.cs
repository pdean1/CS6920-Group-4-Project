using CS6920Group4Project.Controller;
using CS6920Group4Project.Model;
using CS6920Group4Project.Utilities;
using System.Collections.Generic;
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
        /// This is a list of budgets the User has access to
        /// </summary>
        private static List<Budget> _Budgets;

        /// <summary>
        /// The next to static variables are related to the MyBudgetForm's Session Labels.
        /// These two labels will display the username and income remaining for the application.
        /// If more labels are needed declare them here
        /// In order to refresh the view after values in _Budget are updated, 
        ///   call Session.SessionInformation.RefreshSessionLabels()
        /// </summary>
        private static Label _LBLUserName;
        private static Label _LBLIncomeRemaining;

        private static ComboBox _CBBudgets;
        private static Button _BTNSelectBudget;
        private static Button _BTNDeleteBudget;

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
        /// Gets the list of budgets loaded into session
        /// </summary>
        /// <returns>A list of budgets that was loaded into session</returns>
        public static List<Budget> GetBudgets()
        {
            return _Budgets;
        }

        /// <summary>
        /// Sets the list of budgets loaded into session
        /// </summary>
        /// <param name="budgets">List of budgets to set the budgets equal to</param>
        public static void SetBudgets(List<Budget> budgets)
        {
            _Budgets = budgets;
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

        public static void SetBudgetPickerArea(ComboBox cbBudgets, Button btnSelect, Button btnDelete)
        {
            _CBBudgets = cbBudgets;
            _BTNSelectBudget = btnSelect;
            _BTNDeleteBudget = btnDelete;
        }

        public static void RefreshBudgetPickerArea()
        {
            Session.SessionInformation.SetBudgets(BudgetController.Instance.GetUsersBudgets(Session.SessionInformation.GetSessionUser().ID));
            if (Session.SessionInformation.GetBudgets().Count != 0)
            {
                _CBBudgets.DataSource = Session.SessionInformation.GetBudgets();
                _CBBudgets.ValueMember = "ID";
                _CBBudgets.DisplayMember = "Title";
                _CBBudgets.Enabled = true;
                _BTNDeleteBudget.Enabled = true;
                _BTNSelectBudget.Enabled = true;
                Session.SessionInformation.SetCurrentBudget(Session.SessionInformation.GetBudgets()[_CBBudgets.SelectedIndex]);
                if (!BudgetController.Instance.PopulateBudgetWithRecords(Session.SessionInformation.GetBudget()))
                {
                    MessageBox.Show("Unable to populate budget with it's records.");
                    return;
                }
            }
            else
            {
                _CBBudgets.DataSource = null;
                _CBBudgets.Items.Add("Add a budget first");
                _CBBudgets.SelectedIndex = 0;
                _CBBudgets.Enabled = false;
                _BTNDeleteBudget.Enabled = false;
                _BTNSelectBudget.Enabled = false;
                Budget budget = new Budget();
                budget.Bills = new List<Bill>();
                budget.Expenses = new List<Expense>();
                budget.Earnings = new List<Earning>();
                Session.SessionInformation.SetCurrentBudget(budget);
            }
        }

        /// <summary>
        /// This function refreshes the labels after a change is made
        /// </summary>
        public static void RefreshSessionLabels()
        {
            _LBLUserName.Text = Session.SessionInformation.GetSessionUser().FirstName
                + " " + Session.SessionInformation.GetSessionUser().LastName; ;
            if (Session.SessionInformation.GetBudget() == null)
                _LBLIncomeRemaining.Text = StringUtilities.GetDisplayableDollarAmount(0);
            else
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
