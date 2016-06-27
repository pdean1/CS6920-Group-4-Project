using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using CS6920Group4Project.Model;
using CS6920Group4Project.Utilities;
using CS6920Group4Project.Controller;

namespace CS6920Group4Project.DAL.Model
{
    public class ExpenseDAL
    {
        private MySqlConnection conn = new DBConnect().GetConnection();

        private const string InsertExpenseStatment = "INSERT INTO `sql5123046`.`expenses` (`RecordID`, `ExpenseCategoryID`, `Amount`, `DateSpent`) " 
            + "VALUES (@RecordID, @ExpenseCategoryID, @Amount, @DateSpent);";

        public long InsertExpense(Expense expense)
        {
            long id = RecordController.Instance.InsertRecord(expense);
            if (id == 0)
                return 0;
            expense.ID = id;
            using (MySqlCommand command = new MySqlCommand())
            {
                try
                {
                    conn.Open();
                    command.Connection = conn;
                    command.CommandText = InsertExpenseStatment;
                    command.Prepare();
                    command.Parameters.AddWithValue("@RecordID", expense.ID);
                    command.Parameters.AddWithValue("@ExpenseCategoryID", expense.Category.ID);
                    command.Parameters.AddWithValue("@Amount", expense.Amount);
                    command.Parameters.AddWithValue("@DateSpent", expense.DateSpent);
                    command.ExecuteNonQuery();
                    id = command.LastInsertedId;
                }
                catch (MySqlException e)
                {
                    DatabaseErrorMessageUtility.SendMessageToUser("Unable to query for expenses in the database.", e);
                    id = 0;
                }
                catch (Exception e)
                {
                    DatabaseErrorMessageUtility.SendMessageToUser("Unable to query for expenses in the database.", e);
                    id = 0;
                }
                finally
                {
                    conn.Close();
                }
            }
            return id;
        }

        private const string GetListOfExpensesByBudgetIDStatment = 
            "SELECT `viewexpenserecords`.`RecordID`," + 
            "   `viewexpenserecords`.`BudgetID`," +  
            "   `viewexpenserecords`.`RecordType`," +  
            "   `viewexpenserecords`.`Title`," +  
            "   `viewexpenserecords`.`Description`," +  
            "   `viewexpenserecords`.`ExpenseCategoryID`," +  
            "   `viewexpenserecords`.`ExpenseCategoryTitle`," +  
            "   `viewexpenserecords`.`ExpenseCategoryDescription`," +  
            "   `viewexpenserecords`.`Amount`," +  
            "   `viewexpenserecords`.`DateSpent`," +  
            "   `viewexpenserecords`.`DateCreated` " +
            " FROM `sql5123046`.`viewexpenserecords` WHERE `viewexpenserecords`.`BudgetID` = @ID;";

        public List<Expense> GetListOfExpensesByBudgetID(int BudgetID)
        {
            List<Expense> expenses = new List<Expense>();

            try
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.CommandText = GetListOfExpensesByBudgetIDStatment;
                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@ID", BudgetID);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Expense expense = new Expense();
                            expense.ID = reader.GetInt32(0); ;
                            expense.BudgetID = reader.GetInt32(1);
                            expense.RecordType = reader.GetChar(2);
                            expense.Title = reader.GetString(3);
                            try
                            {
                                expense.Description = reader.GetString(4);
                            }
                            catch (Exception)
                            {
                                expense.Description = "";
                            }
                            expense.Category = new ExpenseCategory();
                            expense.Category.ID = reader.GetInt32(5); ;
                            expense.Category.Title = reader.GetString(6);
                            try
                            {
                                expense.Category.Description = reader.GetString(7);
                            }
                            catch (Exception)
                            {
                                expense.Category.Description = "";
                            }
                            expense.Amount = reader.GetDecimal(8);
                            expense.DateSpent = reader.GetDateTime(9);
                            expense.DateCreated = reader.GetDateTime(10);
                            expenses.Add(expense);
                        }
                        reader.Close();
                    }
                }
            }
            catch (MySqlException e)
            {
                expenses = null;
                DatabaseErrorMessageUtility.SendMessageToUser(
                    "Unable to query for expenses in the database.", e);
            }
            catch (Exception e)
            {
                expenses = null;
                DatabaseErrorMessageUtility.SendMessageToUser(
                    "Unable to query for expenses in the database.", e);
            }
            finally
            {
                conn.Close();
            }
            return expenses;
        }

        public List<ExpenseCategory> GetExpenseCategoryList()
        {
            List<ExpenseCategory> expenseCategoryList = new List<ExpenseCategory>();
            try
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT * FROM expensecategories";
                    cmd.Prepare();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var bid = reader.GetOrdinal("ExpenseCategoryID");
                            var bTitle = reader.GetOrdinal("Title");
                            var bDesc = reader.GetOrdinal("Description");

                            ExpenseCategory expenseCategory = new ExpenseCategory();

                            expenseCategory.ID = reader.GetInt32(bid);
                            expenseCategory.Title = reader.GetString(bTitle);
                            expenseCategoryList.Add(expenseCategory);
                        }
                        reader.Close();
                    }
                }
            }
            catch (MySqlException e)
            {
                DatabaseErrorMessageUtility.SendMessageToUser(
                    "Unable to query the ExpenseCategory in the database.", e);
               expenseCategoryList = null;
            }
            finally
            {
                conn.Close();
            }
            return expenseCategoryList;
        }
    }
    }
}
