using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using CS6920Group4Project.DAL;
using CS6920Group4Project.Model;
using CS6920Group4Project.Utilities;

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

            try
            {
                MySqlCommand cmd = new MySqlCommand();
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = SelectAllUsersBudgetsStatement;
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@ID", UserID);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Budget budget = new Budget();
                        budget.ID = reader.GetInt32(0);
                        budget.UserID = reader.GetInt32(1);
                        budget.BudgetTypeID = reader.GetInt32(2);
                        budget.Title = reader.GetString(3);
                        try
                        {
                            budget.Description = reader.GetString(4);
                        }
                        catch (Exception)
                        {
                            budget.Description = "";
                        }
                        budget.DateCreated = reader.GetDateTime(5);
                        budgets.Add(budget);
                    }
                    reader.Close();
                }
            }
            catch (MySqlException e)
            {
                DatabaseErrorMessageUtility.SendMessageToUser("Unable to query for users in the database.", e);
                budgets = null;
            }
            catch (Exception e)
            {
                DatabaseErrorMessageUtility.SendMessageToUser("Unable to query for users in the database.", e);
                budgets = null;
            }
            finally
            {
                conn.Close();
            }
            return budgets;
        }
    }
}
