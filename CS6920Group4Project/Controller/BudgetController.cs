using CS6920Group4Project.DAL.Model;
using CS6920Group4Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS6920Group4Project.Controller
{
    /// <summary>
    /// This class controls access to the Model class Budget's DAL Methods
    /// </summary>
    public class BudgetController
    {
        private static BudgetController instance;

        private readonly BudgetDAL _dal = new BudgetDAL();

        public BudgetController() { }

        public static BudgetController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BudgetController();
                }
                return instance;
            }
        }

        /// <summary>
        /// Calls the BudgetDAL class's GetAllUserBudgets Method to retrieve all budgets associated with a user.
        /// If, however, ID is null or is less than or equal to zero this method will return null
        /// </summary>
        /// <param name="ID">ID of the User to retrieve budgets for</param>
        /// <returns>A List of budgets or null in the case of invalid parameters being passed to the program</returns>
        public List<Budget> GetUsersBudgets(int ID)
        {
            if (ID <= 0)
                return null;
            return _dal.GetAllUserBudgets(ID);
        }

        public Boolean PopulateBudgetsWithRecords(List<Budget> budgets)
        {
            if (budgets == null)
                return false;
            
            foreach (Budget b in budgets)
            {
                if (PopulateBudgetWithRecords(b))
                    continue;
                else
                    return false;
            }

            return true;
        }

        public Boolean PopulateBudgetWithRecords(Budget budget)
        {
            if (budget == null)
                return false;
            budget.Earnings = EarningController.Instance.GetEarningsByBudgetID(budget.ID);
            budget.Expenses = ExpenseController.Instance.GetExpensesByBudgetID(budget.ID);
            budget.Bills = BillController.Instance.GetBillsByBudgetID(budget.ID);
            return true;
        }

        public bool EditBudget(Budget budget)
        {
            return _dal.EditBudget(budget);
        }

        public Boolean DeleteBudget(int id)
        {
            return _dal.DeleteBudget(id);
        }
    }
}
