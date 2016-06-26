using CS6920Group4Project.DAL.Model;
using CS6920Group4Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS6920Group4Project.Controller
{
    class ExpenseController
    {
        private static ExpenseController instance;
        private readonly ExpenseDAL _dal = new ExpenseDAL();
        private ExpenseController() { }
        public static ExpenseController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ExpenseController();
                }
                return instance;
            }
        }
        public List<Expense> GetExpensesByBudgetID(int ID)
        {
            return _dal.GetListOfExpensesByBudgetID(ID);
        }
        public long InsertExpense(Expense e)
        {
            return _dal.InsertExpense(e);
        }
    }
}
