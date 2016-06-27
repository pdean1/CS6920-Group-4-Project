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
    public class EarningDAL
    {
        private MySqlConnection conn = new DBConnect().GetConnection();

        private const string InsertEarningStatement = "INSERT INTO `sql5123046`.`earnings` (`RecordID`, `EarningCategoryID`, `Amount`, `DateEarned`)" 
            + " VALUES (@RecordID, @EarningCategoryID, @Amount, @DateEarned);";

        public long InsertEarning(Earning earning)
        {
            earning.RecordType = 'E';
            long id = RecordController.Instance.InsertRecord(earning);
            if (id == 0)
                return 0;
            earning.ID = id;
            using (MySqlCommand command = new MySqlCommand())
            {
                try
                {
                    conn.Open();
                    command.Connection = conn;
                    command.CommandText = InsertEarningStatement;
                    command.Prepare();
                    command.Parameters.AddWithValue("@RecordID", earning.ID);
                    command.Parameters.AddWithValue("@EarningCategoryID", earning.Category.ID);
                    command.Parameters.AddWithValue("@Amount", earning.Amount);
                    command.Parameters.AddWithValue("@DateEarned", earning.DateEarned.ToString("yyyy-MM-dd hh:mm:ss"));
                    command.ExecuteNonQuery();
                    id = command.LastInsertedId;
                }
                catch (MySqlException e)
                {
                    DatabaseErrorMessageUtility.SendMessageToUser("Unable to query for users in the database.", e);
                    id = 0;
                }
                catch (Exception e)
                {
                    DatabaseErrorMessageUtility.SendMessageToUser("Unable to query for users in the database.", e);
                    id = 0;
                }
                finally
                {
                    conn.Close();
                }    
            }
            return id;
        }

        private const string SelectEarningsByBudgetIDStatement = 
            "SELECT `viewearningrecords`.`RecordID`, " +
            "`viewearningrecords`.`BudgetID`, " +
            "`viewearningrecords`.`RecordType`, " +
            "`viewearningrecords`.`Title`, " +
            "`viewearningrecords`.`Description`, " +
            "`viewearningrecords`.`EarningCategoryID`, " +
            "`viewearningrecords`.`Earning`, " +
            "`viewearningrecords`.`EarningCategoryDescription`, " +
            "`viewearningrecords`.`Amount`, " +
            "`viewearningrecords`.`DateEarned`, " +
            "`viewearningrecords`.`DateCreated` FROM `sql5123046`.`viewearningrecords`" +
            "WHERE `viewearningrecords`.`BudgetID` = @ID;";

        public List<Earning> GetEarningsByBudgetID(int BudgetID)
        {
            List<Earning> earnings = new List<Earning>();
            try
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.CommandText = SelectEarningsByBudgetIDStatement;
                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@ID", BudgetID);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Earning earning = new Earning();
                            earning.ID = reader.GetInt32(0);
                            earning.BudgetID = reader.GetInt32(1);
                            earning.RecordType = reader.GetChar(2);
                            earning.Title = reader.GetString(3);
                            try
                            {
                                earning.Description = reader.GetString(4);
                            }
                            catch (Exception)
                            {
                                earning.Description = "";
                            }
                            earning.Category = new EarningCategory();
                            earning.Category.ID = reader.GetInt32(5);
                            earning.Category.Title = reader.GetString(6);
                            try
                            {
                                earning.Category.Description = reader.GetString(7);
                            }
                            catch (Exception)
                            {
                                earning.Category.Description = "";
                            }
                            earning.Amount = reader.GetDecimal(8);
                            earning.DateEarned = reader.GetDateTime(9);
                            earning.DateCreated = reader.GetDateTime(10);
                            earnings.Add(earning);
                        }
                        reader.Close();
                    }
                }
            }
            catch (MySqlException e)
            {
                earnings = null;
                DatabaseErrorMessageUtility.SendMessageToUser(
                    "Unable to query for earnings in the database.", e);
            }
            catch (Exception e)
            {
                earnings = null;
                DatabaseErrorMessageUtility.SendMessageToUser(
                    "Unable to query for earnings in the database.", e);
            }
            finally
            {
                conn.Close();
            }
            return earnings;
        }
        public void showEarnings()
        {
           
        }
        /// <summary>
        /// series of query to add earnings to the database
        /// </summary>
        /// <param name="earn"></param>
        public void AddEarning(Earning earn)
        {
            
            MySqlConnection conn = new DBConnect().GetConnection();

            //record to insert statement inserting into record table
            String InsertRecordStatement = "INSERT INTO `sql5123046`.`records`" +
                                            "(`BudgetID`, `RecordType`, `Title`, `Description`, `DateCreated`)" +
                                            "VALUES (@BudgetID, @RecordType, @Title, @Description, @DateCreated)";

                        
            MySqlCommand insertRecordCommand = new MySqlCommand(InsertRecordStatement, conn);
            insertRecordCommand.Parameters.AddWithValue("@BudgetID", 1);
            insertRecordCommand.Parameters.AddWithValue("RecordType", earn.RecordType);
            insertRecordCommand.Parameters.AddWithValue("@Title", earn.Title);
            insertRecordCommand.Parameters.AddWithValue("@Description", earn.Description);
            insertRecordCommand.Parameters.AddWithValue("@DateCreated", earn.DateCreated);


            String InsertEarnStatement = "INSERT INTO `sql5123046`.`earnings`" +
                                       "(`RecordID`,`EarningCategoryID`,`Amount`,`DateEarned`)" +
                                       "VALUES(@RecordID, @EarningCategoryID, @Amount, @DateEarned)";      
     
           
            MySqlCommand insertEarnCommand = new MySqlCommand(InsertEarnStatement, conn);
            insertEarnCommand.Parameters.AddWithValue("@Amount", earn.Amount);
            insertEarnCommand.Parameters.AddWithValue("@DateEarned", earn.DateEarned);

            //to check if we already have the same title/description in the earningcategory table
            String SelectEarnCategoryStatement = "SELECT `EarningCategoryID` FROM `sql5123046`.`earningscategory` WHERE `Title` = @Title AND `Description` = @Description";
            MySqlCommand selectEarnCategoryCommand = new MySqlCommand(SelectEarnCategoryStatement, conn);
            selectEarnCategoryCommand.Parameters.AddWithValue("@Title", earn.Category.Title);
            selectEarnCategoryCommand.Parameters.AddWithValue("@Description", earn.Category.Description);

           //query to add a new earning to the category if it doesn't have one yet
            String InsertEarnCategoryStatement = "INSERT INTO `sql5123046`.`earningscategory`" +
                                         "(`EarningCategoryID`, `Title`,`Description`)" +
                                         "VALUES(@EarningCategoryId, @Title, @Description)";
            MySqlCommand insertEarnCategoryCommand = new MySqlCommand(InsertEarnCategoryStatement, conn);
            insertEarnCategoryCommand.Parameters.AddWithValue("@Title", earn.Category.Title);
            insertEarnCategoryCommand.Parameters.AddWithValue("@Description", earn.Category.Description);

            try
            {
                conn.Open();
                insertRecordCommand.ExecuteNonQuery();
                earn.ID = insertRecordCommand.LastInsertedId;
                insertEarnCommand.Parameters.AddWithValue("@RecordID", earn.ID);

                bool foundCategory = false;
                using (MySqlDataReader reader = selectEarnCategoryCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        earn.Category.EarningCategoryID = reader.GetInt32(0);
                        foundCategory = true;
                    }
                    reader.Close();
                }
                if (!foundCategory)
                {
                    // creates a new insert category
                    insertEarnCategoryCommand.ExecuteNonQuery();
                    earn.Category.EarningCategoryID = (int)insertEarnCategoryCommand.LastInsertedId;
                }

                insertEarnCommand.Parameters.AddWithValue("@EarningCategoryID", earn.Category.EarningCategoryID);
                insertEarnCommand.ExecuteNonQuery();

            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            finally
            {
                insertRecordCommand.Dispose();
                insertEarnCommand.Dispose();
                insertEarnCategoryCommand.Dispose();
                selectEarnCategoryCommand.Dispose();
                conn.Close();
            }

        }
    }
}
