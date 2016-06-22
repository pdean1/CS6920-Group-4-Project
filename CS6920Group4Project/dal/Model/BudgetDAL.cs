using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using CS6920Group4Project.dal;
using CS6920Group4Project.model;

namespace CS6920Group4Project.DAL.Model
{
    public class BudgetDAL
    {
        private MySqlConnection conn = new DBConnect().GetConnection();

        private const string InsertBudgetStatement = "";

        public long InsertBudget(Budget budget)
        {
            return 0;
        }

        private const string SelectAllUsersBudgetsStatement = "SELECT `budgets`.`BudgetID`, `budgets`.`UserID`, `budgets`.`BudgetTypeID`, " +
            "`budgets`.`Title`, `budgets`.`Description`, `budgets`.`DateCreated` FROM `sql5123046`.`budgets`" +
            " WHERE `budgets`.`UserID` = @ID;";

        public List<Budget> GetAllUserBudgets (int UserID)
        {
            List<Budget> budgets = new List<Budget>();

            return budgets;
        }
    }
}
