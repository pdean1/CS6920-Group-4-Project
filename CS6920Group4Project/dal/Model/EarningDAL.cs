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

        private const string InsertEarningStatement = "INSERT INTO `sql5123046`.`earnings` (`RecordID`, `Amount`, `DateEarned`)" 
            + " VALUES (@RecordID, @Amount, @DateEarned);";

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
                    command.Parameters.AddWithValue("@Amount", earning.Amount);
                    command.Parameters.AddWithValue("@DateEarned", Utilities.StringUtilities.GetLongDateString(earning.DateEarned));
                    command.ExecuteNonQuery();
                }
                catch (MySqlException e)
                {
                    DatabaseErrorMessageUtility.SendMessageToUser("Unable to insert earning into the database.", e);
                    return 0;
                }
                catch (Exception e)
                {
                    DatabaseErrorMessageUtility.SendMessageToUser("Unable to insert earning into the database.", e);
                    return 0;
                }
                finally
                {
                    conn.Close();
                }    
            }
            Session.SessionInformation.GetBudget().Earnings.Add(earning);
            return id;
        }

        private const string SelectEarningsByBudgetIDStatement = 
            "SELECT * FROM `sql5123046`.`viewearningrecords` WHERE `viewearningrecords`.`BudgetID` = @ID;";

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
                            earning.Amount = reader.GetDecimal(5);
                            earning.DateEarned = reader.GetDateTime(6);
                            earning.DateCreated = reader.GetDateTime(7);
                            earnings.Add(earning);
                        }
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


        public bool EditEarnings(Earning earning) 
        {
            bool update = false;

            MySqlConnection connection = new DBConnect().GetConnection();

            String updateEarningsStatement = "UPDATE `sql5123046`.`records` as r join `sql5123046`.`earnings` as e on r.RecordID = e.RecordID " +
                                             "SET Title = @Title, Description = @Description, Amount = @Amount, DateEarned = @DateEarned " +
                                             "where r.RecordID = @RecordID";

            MySqlCommand updateEarnCommand = new MySqlCommand(updateEarningsStatement, connection);

            updateEarnCommand.Parameters.AddWithValue("@RecordID", earning.ID);
            updateEarnCommand.Parameters.AddWithValue("@Title", earning.Title);
            updateEarnCommand.Parameters.AddWithValue("@Description", earning.Description);
            updateEarnCommand.Parameters.AddWithValue("@Amount", earning.Amount);
            updateEarnCommand.Parameters.AddWithValue("@DateEarned", Utilities.StringUtilities.GetLongDateString(earning.DateEarned));

            MySqlTransaction trans = null;
            try
            {
                connection.Open();
                trans = connection.BeginTransaction();

                updateEarnCommand.Transaction = trans;

                int updateCode = updateEarnCommand.ExecuteNonQuery();
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
                DatabaseErrorMessageUtility.SendMessageToUser("Unable to update Database with Earnings.", ex);
            }
            catch (Exception ex)
            {
                DatabaseErrorMessageUtility.SendMessageToUser("Unable to update Database with Earnings.", ex);
            }
            finally
            {
                updateEarnCommand.Dispose();
                connection.Close();
            }
            return update;
            }
        public MySqlDataAdapter listEarningsForDataGrid(int BudgetID)
        {
            MySqlDataAdapter mySqlDataAdapter = null;

            try
            {
                using (MySqlCommand command = new MySqlCommand())
                {
                    conn.Open();
                    command.Connection = conn;
                    command.CommandText = "SELECT * FROM `sql5123046`.`viewearningrecords` WHERE `viewearningrecords`.`BudgetID` = @ID;";
                    command.Prepare();
                    command.Parameters.AddWithValue("@ID", BudgetID);
                    mySqlDataAdapter = new MySqlDataAdapter(command);
                }
            }
            catch (MySqlException ex)
            {
                DatabaseErrorMessageUtility.SendMessageToUser("Unable to query for earnings view in the database.", ex);
            }
            catch (Exception ex)
            {
                DatabaseErrorMessageUtility.SendMessageToUser("Unable to query for earnings view in the database.", ex);
            }
            finally
            {
                conn.Close();
            }
            return mySqlDataAdapter;
        }

        public bool DeleteEarning(Earning delEarning)
        {
            MySqlTransaction delEarningTran = null;
            bool earningDelete = false;

            try
            {
                string deleteStatement = "DELETE from records WHERE RecordID    = @ID " +
                                                               "and BudgetID    = @bID " +
                                                               "and RecordType  = @recType " +
                                                               "and Title       = @title " +
                                                               "and Description = @desc " +
                                                               "and DateCreated = @dateCreated";
                MySqlCommand deleteCommand = new MySqlCommand(deleteStatement, conn);
                deleteCommand.Parameters.AddWithValue("@ID", delEarning.ID);
                deleteCommand.Parameters.AddWithValue("@bID", delEarning.BudgetID);
                deleteCommand.Parameters.AddWithValue("@recType", delEarning.RecordType);
                deleteCommand.Parameters.AddWithValue("@title", delEarning.Title);
                if (String.IsNullOrEmpty(delEarning.Description))
                    deleteCommand.Parameters.AddWithValue("@desc", DBNull.Value);
                else
                    deleteCommand.Parameters.AddWithValue("@desc", delEarning.Description);
                deleteCommand.Parameters.AddWithValue("@dateCreated", Utilities.StringUtilities.GetLongDateString(delEarning.DateCreated));

                conn.Open();
                delEarningTran = conn.BeginTransaction();
                deleteCommand.Transaction = delEarningTran;
                int isRecordDeleted = deleteCommand.ExecuteNonQuery();
                if (isRecordDeleted > 0)
                {
                    delEarningTran.Commit();
                    return earningDelete = true;
                }
                else
                {
                    delEarningTran.Rollback();
                    return earningDelete = false;
                }
            }
            catch (MySqlException e)
            {
                DatabaseErrorMessageUtility.SendMessageToUser(
                    "Unable to query for delete Earning in the database.", e);
            }
            catch (Exception e)
            {
                if (delEarningTran != null)
                    delEarningTran.Rollback();

                DatabaseErrorMessageUtility.SendMessageToUser(
                    "Unable to query for delete Earning in the database.", e);
            }
            finally
            {
                conn.Close();
            }
            return earningDelete;
        }
      }

}
