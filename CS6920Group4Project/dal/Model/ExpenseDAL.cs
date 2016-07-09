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

        private const string InsertExpenseStatment = "INSERT INTO `sql5123046`.`expenses` (`RecordID`, `Amount`, `DateSpent`) " 
            + "VALUES (@RecordID, @Amount, @DateSpent);";

        public long InsertExpense(Expense expense)
        {
            expense.RecordType = 'X';
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
                    command.Parameters.AddWithValue("@Amount", expense.Amount);
                    command.Parameters.AddWithValue("@DateSpent", expense.DateSpent.ToString("yyyy-MM-dd hh:mm:ss"));
                    command.ExecuteNonQuery();
                }
                catch (MySqlException e)
                {
                    DatabaseErrorMessageUtility.SendMessageToUser("Unable to query for expenses in the database.", e);
                    return 0;
                }
                catch (Exception e)
                {
                    DatabaseErrorMessageUtility.SendMessageToUser("Unable to query for expenses in the database.", e);
                    return 0;
                }
                finally
                {
                    conn.Close();
                }
            }
            Session.SessionInformation.GetBudget().Expenses.Add(expense);
            Session.SessionInformation.RefreshSessionLabels();
            return id;
        }



        private const string GetListOfExpensesByBudgetIDStatment = 
            "SELECT * FROM `sql5123046`.`viewexpenserecords` WHERE `viewexpenserecords`.`BudgetID` = @ID;";

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
                            expense.Amount = reader.GetDecimal(5);
                            expense.DateSpent = reader.GetDateTime(6);
                            expense.DateCreated = reader.GetDateTime(7);
                            expenses.Add(expense);
                        }
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
        public bool EditExpenses(Expense expense)
        {
            bool update = false;
            MySqlConnection connection = new DBConnect().GetConnection();

            String editExpenseStatement = "UPDATE `sql5123046`.`records` as r join `sql5123046`.`expenses` as e on r.RecordID = e.RecordID " +
                                             "SET Title = @Title, Description = @Description, Amount = @Amount, DateSpent = @DateSpent " +
                                             "where r.RecordID = @RecordID";

            MySqlCommand editExpenseCommand = new MySqlCommand(editExpenseStatement, connection);

            editExpenseCommand.Parameters.AddWithValue("@RecordID", expense.ID);
            editExpenseCommand.Parameters.AddWithValue("@Title", expense.Title);
            editExpenseCommand.Parameters.AddWithValue("@Description", expense.Description);
            editExpenseCommand.Parameters.AddWithValue("@Amount", expense.Amount);
            editExpenseCommand.Parameters.AddWithValue("@DateSpent", expense.DateSpent);

            MySqlTransaction trans = null;
            try
            {
                connection.Open();
                trans = connection.BeginTransaction();

                editExpenseCommand.Transaction = trans;

                int updateCode = editExpenseCommand.ExecuteNonQuery();
                if (updateCode > 0)
                {
                    trans.Commit();
                    update = true;
                }
                else
                {
                    update = false;
                }
            }
            catch (MySqlException ex)
            {
                trans.Rollback();
                DatabaseErrorMessageUtility.SendMessageToUser("Unable to update Database with Expenses.", ex);
            }
            catch (Exception ex)
            {
                DatabaseErrorMessageUtility.SendMessageToUser("Unable to update Database with Expenses.", ex);
            }
            finally
            {
                editExpenseCommand.Dispose();
                connection.Close();
            }
            return update;
        }
       
        public MySqlDataAdapter GetListOfExpensesByBudgetIDDataGridView(int BudgetID)
        {
            MySqlDataAdapter mySqlDataAdapter = null;

            try
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT * " +
                                      "FROM `sql5123046`.`viewexpenserecords` WHERE `viewexpenserecords`.`BudgetID` = @ID " +
                                      "ORDER BY DateSpent DESC;";
                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@ID", BudgetID);
                    mySqlDataAdapter = new MySqlDataAdapter(cmd);
                }
            }
            catch (MySqlException e)
            {
                DatabaseErrorMessageUtility.SendMessageToUser(
                    "Unable to query for expense view in the database.", e);
            }
            catch (Exception e)
            {
                DatabaseErrorMessageUtility.SendMessageToUser(
                    "Unable to query for expense view in the database.", e);
            }
            finally
            {
                conn.Close();
            }
            return mySqlDataAdapter;
        }

        public bool DeleteExpense(Expense delExpense)
        {
            MySqlTransaction delExpenseTran = null;
            bool expenseDelete = true;

            try
            {
               //  delete expense
               string deleteStatement1 = "DELETE from expenses WHERE RecordID = @ID " +
                                                                "and Amount = @amount " +
                                                                "and DateSpent = @dateSpent ";

               MySqlCommand deleteCommand1 = new MySqlCommand(deleteStatement1, conn);
               deleteCommand1.Parameters.AddWithValue("@ID", delExpense.ID);
               deleteCommand1.Parameters.AddWithValue("@amount", delExpense.Amount);
               deleteCommand1.Parameters.AddWithValue("@dateSpent", delExpense.DateSpent);

                // delete record
                string deleteStatement2 = "DELETE from records WHERE RecordID = @ID " +
                                                               "and BudgetID = @bID " +
                                                               "and RecordType = @recType " +
                                                               "and Title = @title " +
                                                               "and Description = @desc " +
                                                               "and DateCreated = @dateCreated"; 

               MySqlCommand deleteCommand2 = new MySqlCommand(deleteStatement2, conn);
               deleteCommand2.Parameters.AddWithValue("@ID", delExpense.ID);
               deleteCommand2.Parameters.AddWithValue("@bID", delExpense.BudgetID);
               deleteCommand2.Parameters.AddWithValue("@recType", delExpense.RecordType);
               deleteCommand2.Parameters.AddWithValue("@title", delExpense.Title);
               deleteCommand2.Parameters.AddWithValue("@desc", delExpense.Description);
               deleteCommand2.Parameters.AddWithValue("@dateCreated", delExpense.DateCreated);

               conn.Open();
               delExpenseTran = conn.BeginTransaction();
               deleteCommand1.Transaction = delExpenseTran;
               deleteCommand2.Transaction = delExpenseTran;

               int isExpenseDeleted = deleteCommand1.ExecuteNonQuery();
               if (isExpenseDeleted > 0)
               {
                   int isRecordDeleted = deleteCommand2.ExecuteNonQuery();
                   if (isRecordDeleted > 0)
                   {
                       delExpenseTran.Commit();
                       return expenseDelete = true;
                   }
                   else
                   {
                       delExpenseTran.Rollback();
                       return expenseDelete = false;
                   }
               }
               else
               {
                   delExpenseTran.Rollback();
                   return expenseDelete = false;
               }
            }
            catch (MySqlException e)
            {
                DatabaseErrorMessageUtility.SendMessageToUser(
                    "Unable to query for delete expense in the database.", e);
            }
            catch (Exception e)
            {
                if (delExpenseTran != null)
                    delExpenseTran.Rollback();

                DatabaseErrorMessageUtility.SendMessageToUser(
                    "Unable to query for delete expense in the database.", e);
            }
            finally
            {
                conn.Close();
            }
            return expenseDelete;
        }
        
    }
}
