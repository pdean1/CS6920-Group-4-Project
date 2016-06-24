using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using CS6920Group4Project.Model;
using CS6920Group4Project.Utilities;

namespace CS6920Group4Project.DAL.Model
{
    public class BillDAL
    {
        private MySqlConnection conn = new DBConnect().GetConnection();

        private const string InsertBillStatement = 
            "INSERT INTO sql5123046.bills(RecordID, BillCategoryID, Amount, DateDue, DatePaid) VALUES (@RecordID, @BillCategoryID, @Amount, @DateDue, @DatePaid)";

        public long InsertBill(Bill bill)
        {
            return 0;
        }

        private const string SelectBillsByBudgetID = 
            "SELECT `viewbillrecords`.`RecordID`, " + 
            "`viewbillrecords`.`BudgetID`, " + 
            "`viewbillrecords`.`RecordType`, " + 
            "`viewbillrecords`.`Title`, " +
            "`viewbillrecords`.`Description`, " +
            "`viewbillrecords`.`BillCategoryID`, " +
            "`viewbillrecords`.`BillCategoryTitle`, " +
            "`viewbillrecords`.`BillCategoryDescription`, " +
            "`viewbillrecords`.`Amount`, " +
            "`viewbillrecords`.`DateDue`, " +
            "`viewbillrecords`.`DatePaid`, " +
            "`viewbillrecords`.`DateCreated` " +
            "FROM `sql5123046`.`viewbillrecords` WHERE `viewbillrecords`.`BudgetID` = @ID;";

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
                            bill.Category = new BillCategory();
                            bill.Category.ID = reader.GetInt32(5);
                            bill.Category.Title = reader.GetString(6);
                            try
                            {
                                bill.Category.Description = reader.GetString(7);
                            }
                            catch (Exception)
                            {
                                bill.Category.Description = "";
                            }
                            bill.Amount = reader.GetDecimal(8);
                            bill.DateDue = reader.GetDateTime(9);
                            try
                            {
                                bill.DateDue = reader.GetDateTime(10);
                            }
                            catch (Exception)
                            {
                                bill.DatePaid = null;
                            }
                            bill.DateCreated = reader.GetDateTime(11);
                            bills.Add(bill);
                        }
                        reader.Close();
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
    }
}
