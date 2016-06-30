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

        private const string SelectAllUsersBudgetsStatement = "SELECT * FROM `sql5123046`.`budgets` WHERE `budgets`.`UserID` = @ID;";

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
                        budget.Title = reader.GetString(2);
                        try
                        {
                            budget.Description = reader.GetString(3);
                        }
                        catch (Exception)
                        {
                            budget.Description = "";
                        }
                        
                        budget.DateCreated = reader.GetDateTime(4);
                        budgets.Add(budget);
                    }
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
