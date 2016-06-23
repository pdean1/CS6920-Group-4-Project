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
    /// <summary>
    /// Contains methods relating to updating, inserting, and deleting records from the Record 
    /// table in the database
    /// </summary>
    public class RecordDAL
    {
        private MySqlConnection conn = new DBConnect().GetConnection();

        private String SelectRecordsByBudgetIDStatement = 
            "SELECT `records`.`RecordID`, " + 
            "`records`.`BudgetID`, " +
            "`records`.`RecordType`, " +
            "`records`.`Title`, " +
            "`records`.`Description`, " +
            "`records`.`DateCreated` " +
            "FROM `sql5123046`.`records` WHERE `records`.`BudgetID` = @ID;";

        /// <summary>
        /// Returns a list of records associated to a budget
        /// </summary>
        /// <param name="BudgetID">The budget ID for the records to be pulled from</param>
        /// <returns>A list of records in the budget or null on an error return</returns>
        public List<Record> GetRecordsByBudgetID(int BudgetID)
        {
            List<Record> records = new List<Record>();
            Record record = new Record();
            try
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.CommandText = SelectRecordsByBudgetIDStatement;
                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@ID", BudgetID);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            record.ID = reader.GetInt32(0);
                            record.BudgetID = reader.GetInt32(1);
                            record.RecordType = reader.GetChar(2);
                            record.Title = reader.GetString(3);
                            try
                            {
                                record.Description = reader.GetString(4);
                            }
                            catch (Exception)
                            {
                                record.Description = "";
                            }
                            record.DateCreated = reader.GetDateTime(5);
                            records.Add(record);
                        }
                        reader.Close();
                    }
                }
            }
            catch (MySqlException e)
            {
                DatabaseErrorMessageUtility.SendMessageToUser(
                    "Unable to query for records in the database.", e);
                records = null;
            }
            catch (Exception e)
            {
                DatabaseErrorMessageUtility.SendMessageToUser(
                    "Unable to query for records in the database.", e);
                records = null;
            }
            finally
            {
                conn.Close();
            }
            return records;
        }
    }
}
