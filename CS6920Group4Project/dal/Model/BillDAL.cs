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
                command.Parameters.AddWithValue("@Amount", Utilities.StringUtilities.Get4PointDecimal(bill.Amount));
                command.Parameters.AddWithValue("@DateDue", Utilities.StringUtilities.GetLongDateString(bill.DateDue));
                if (bill.DatePaid == null)
                {
                    command.Parameters.AddWithValue("@DatePaid", DBNull.Value);
                }
                else
                {
                    command.Parameters.AddWithValue("@DatePaid", Utilities.StringUtilities.GetLongDateString((DateTime)bill.DatePaid));
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

        public bool EditBill(Bill bill)
        {
            bool update = false;

            MySqlConnection connection = new DBConnect().GetConnection();

            String updateBillsStatement = "UPDATE `sql5123046`.`records` as r join `sql5123046`.`bills` as b on r.RecordID = b.RecordID " +
                                             "SET Title = @Title, Description = @Description, Amount = @Amount, DateDue = @DateDue, DatePaid = @DatePaid " +
                                             "where r.RecordID = @RecordID";

            MySqlCommand updateBillCommand = new MySqlCommand(updateBillsStatement, connection);

            updateBillCommand.Parameters.AddWithValue("@RecordID", bill.ID);
            updateBillCommand.Parameters.AddWithValue("@Title", bill.Title);
            updateBillCommand.Parameters.AddWithValue("@Description", bill.Description);
            updateBillCommand.Parameters.AddWithValue("@Amount", Utilities.StringUtilities.Get4PointDecimal(bill.Amount));
            updateBillCommand.Parameters.AddWithValue("@DateDue", Utilities.StringUtilities.GetLongDateString(bill.DateDue));
            if (bill.DatePaid == null)
            {
                updateBillCommand.Parameters.AddWithValue("@DatePaid", DBNull.Value);
            }
            else
            {
                updateBillCommand.Parameters.AddWithValue("@DatePaid", Utilities.StringUtilities.GetLongDateString((DateTime)bill.DatePaid));
            }

            MySqlTransaction trans = null;
            try
            {
                connection.Open();
                trans = connection.BeginTransaction();

                updateBillCommand.Transaction = trans;

                int updateCode = updateBillCommand.ExecuteNonQuery();
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
                DatabaseErrorMessageUtility.SendMessageToUser("Unable to update Database with Bills.", ex);
            }
            catch (Exception ex)
            {
                DatabaseErrorMessageUtility.SendMessageToUser("Unable to update Database with Bills.", ex);
            }
            finally
            {
                updateBillCommand.Dispose();
                connection.Close();
            }
            return update;
        }

        public Boolean DeleteBill(Bill b)
        {
            return RecordController.Instance.DeleteRecord(b);
        }
    }
}
