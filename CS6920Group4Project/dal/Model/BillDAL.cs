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
    public class BillDAL
    {
        private MySqlConnection conn = new DBConnect().GetConnection();

        private const string InsertBillStatement = 
            "INSERT INTO sql5123046.bills(RecordID, Amount, DateDue, DatePaid) VALUES" 
            + " (@RecordID, @Amount, @DateDue, @DatePaid)";

        public long InsertBill(Bill bill)
        {
            bill.RecordType = 'B';
            long id = RecordController.Instance.InsertRecord(bill);
            if (id == 0)
                return 0;
            bill.ID = id;
            MySqlCommand command = new MySqlCommand();
            try
            {
                conn.Open();
                command.Connection = conn;
                command.CommandText = InsertBillStatement;
                command.Prepare();
                command.Parameters.AddWithValue("@RecordID", bill.ID);
                command.Parameters.AddWithValue("@Amount", bill.Amount);
                command.Parameters.AddWithValue("@DateDue", bill.DateDue.ToString("yyyy-MM-dd hh:mm:ss"));
                if (bill.DatePaid == null)
                {
                    command.Parameters.AddWithValue("@DatePaid", DBNull.Value);
                }
                else
                {
                    command.Parameters.AddWithValue("@DatePaid", bill.DatePaid.Value.ToLongDateString());
                }
                command.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                DatabaseErrorMessageUtility.SendMessageToUser("Problem adding Record information to the database.", e);
                return 0;
            }
            catch (Exception e)
            {
                DatabaseErrorMessageUtility.SendMessageToUser("Problem adding Record information to the database.", e);
                return 0;
            }
            finally
            {
                conn.Close();
            }
            Session.SessionInformation.GetBudget().Bills.Add(bill);
            return id;
        }

        private const string SelectBillsByBudgetID = 
            "SELECT * FROM `sql5123046`.`viewbillrecords` WHERE `viewbillrecords`.`BudgetID` = @ID;";

        public List<Bill> GetBillsByBudgetID(int BudgetID)
        {
            List<Bill> bills = new List<Bill>();
            try
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.CommandText = SelectBillsByBudgetID;
                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@ID", BudgetID);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Bill bill = new Bill();
                            bill.ID = reader.GetInt32(0);
                            bill.BudgetID = reader.GetInt32(1);
                            bill.RecordType = reader.GetChar(2);
                            bill.Title = reader.GetString(3);
                            try
                            {
                                bill.Description = reader.GetString(4);
                            }
                            catch (Exception)
                            {
                                bill.Description = "";
                            }
                            bill.Amount = reader.GetDecimal(5);
                            bill.DateDue = reader.GetDateTime(6);
                            try
                            {
                                bill.DatePaid = reader.GetDateTime(7);
                            }
                            catch (Exception)
                            {
                                bill.DatePaid = null;
                            }
                            bill.DateCreated = reader.GetDateTime(8);
                            bills.Add(bill);
                        }
                    }
                }
            }
            catch(MySqlException e)
            {
                DatabaseErrorMessageUtility.SendMessageToUser(
                    "Unable to query for bills in the database.", e);
                bills = null;
            }
            catch (Exception e)
            {
                DatabaseErrorMessageUtility.SendMessageToUser(
                    "Unable to query for bills in the database.", e);
                bills = null;
            }
            finally
            {
                conn.Close();
            }
            return bills;
        }
        public static void EditBill(Bill bill)
        {
            MySqlConnection connection = new DBConnect().GetConnection();
            String editBillStatement = "UPDATE sql5123046.bills (`RecordID`, `Amount`, `DateDue`, DatePaid)" +
                                                "SET (RecordID, @Amount, @DateDue, @DatePaid)" +
                                                    " WHERE `RecordID` = @RecordID";

            MySqlCommand editBillCommand = new MySqlCommand(editBillStatement, connection);

            editBillCommand.Parameters.AddWithValue("@RecordID", bill.ID);
            editBillCommand.Parameters.AddWithValue("@Amount", bill.Amount);
            editBillCommand.Parameters.AddWithValue("@DateDue", bill.DateDue.ToString("yyyy-MM-dd hh:mm:ss"));
            //editBillCommand.Parameters.AddWithValue("@DatePaid", bill.DatePaid.ToString("yyyy-MM-dd hh:mm:ss"));

            try
            {
                connection.Open();
                editBillCommand.ExecuteNonQuery();
        
            }
            catch (MySqlException ex)
            {
                DatabaseErrorMessageUtility.SendMessageToUser("Unable to update billing information in the database.", ex);
            }
            catch (Exception ex)
            {
                DatabaseErrorMessageUtility.SendMessageToUser("Unable to update billing information in the database.", ex);
            }
            finally 
            {
                editBillCommand.Dispose();
                connection.Close();
            }
        }
        private const string DeleteBillStatement = "DELETE FROM `sql5123046`.`bills` WHERE " + 
            "`bills`.`RecordID` = @RecordID";// AND " + 
            //"`bills`.`Amount` = @Amount AND " + 
            //"`bills`.`DateDue` = @DateDue;";// AND " + 
            //"`bills`.`DatePaid` = @DatePaid;"
        public Boolean DeleteBill(Bill b)
        {
            var success = false;
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.CommandText = DeleteBillStatement;
                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@RecordID", b.ID);
                    //cmd.Parameters.AddWithValue("@Amount", b.Amount);
                    //cmd.Parameters.AddWithValue("@DateDue", b.DateDue);
              //      if (String.IsNullOrEmpty(b.DatePaid.ToString()))
              //      {
              //          cmd.Parameters.AddWithValue("@DatePaid", "");
              //      }
              //      else
              //      {
              //          cmd.Parameters.AddWithValue("@DatePaid", b.DatePaid);
              //      }
                    if (cmd.ExecuteNonQuery() != 0)
                    {
                        success = true;
                    }
                }
                catch (MySqlException e)
                {
                    DatabaseErrorMessageUtility.SendMessageToUser(
                        "Unable to delete bill from database.", e);
                    success = false;
                }
                catch (Exception e)
                {
                    DatabaseErrorMessageUtility.SendMessageToUser(
                        "Unable to delete bill from database.", e);
                    success = false;
                }
                finally
                {
                    conn.Close();
                }
                if (success)
                    success = RecordController.Instance.DeleteRecord(b);
                return success;
            }
        }
    }
}
