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
                    command.Parameters.AddWithValue("@DateEarned", earning.DateEarned.ToString("yyyy-MM-dd hh:mm:ss"));
                    command.ExecuteNonQuery();
                }
                catch (MySqlException e)
                {
                    DatabaseErrorMessageUtility.SendMessageToUser("Unable to insert earning into the database.", e);
                    id = 0;
                }
                catch (Exception e)
                {
                    DatabaseErrorMessageUtility.SendMessageToUser("Unable to insert earning into the database.", e);
                    id = 0;
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


        public bool EditEarnings(Earning newEarning, Earning oldEarning) 
        {
            MySqlConnection connection = new DBConnect().GetConnection();
            bool update = true;

            String updateEarningsStatement = "UPDATE `sql5123046.records` as r join `sql5123046.earnings` as e on r.RecordID = e.RecordID " +
                                                  "SET Title = (updateTitle, Description = updateDesc, " +
                                                      "Amount = updateAmount, DateEarned = updateDateEarned " +
                                              "where r.RecordID = @ID and e.Amount = @Amount and eDateEarned = @DateEarned" +
                                                      "and r.BudgetID = @BID and r.RecordType = @RecType and r.Title = @Title" +
                                                         "and r.Description = @Desc and r.DateCreated = @DateCreated";

            MySqlCommand updateEarnCommand = new MySqlCommand(updateEarningsStatement, connection);

            updateEarnCommand.Parameters.AddWithValue("@ID", newEarning.ID);
            updateEarnCommand.Parameters.AddWithValue("@Amount", newEarning.Amount);
            updateEarnCommand.Parameters.AddWithValue("@DateEarned", newEarning.DateEarned);
            updateEarnCommand.Parameters.AddWithValue("@Desc", newEarning.Description);
            updateEarnCommand.Parameters.AddWithValue("@ID", oldEarning.ID);
            updateEarnCommand.Parameters.AddWithValue("@BID", oldEarning.BudgetID);
            updateEarnCommand.Parameters.AddWithValue("@RecType", oldEarning.RecordType);
            updateEarnCommand.Parameters.AddWithValue("@Title", oldEarning.Title);
            updateEarnCommand.Parameters.AddWithValue("@Desc", oldEarning.Description);
            updateEarnCommand.Parameters.AddWithValue("@DateCreated", oldEarning.DateCreated);

            MySqlTransaction trans = null;
            MySqlDataReader reader = null;
            try
            {
                connection.Open();
                trans = connection.BeginTransaction();

                updateEarnCommand.Transaction = trans;
                reader = updateEarnCommand.ExecuteReader();

                int updateCode = updateEarnCommand.ExecuteNonQuery();
                if (updateCode > 0)

                    return update = true;
                else
                    return update = false;
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
            bool earningDelete = true;

            try
            {
                //  delete Earning
                string deleteStatement1 = "DELETE from earnings WHERE RecordID = @ID " +
                                                                 "and Amount = @amount " +
                                                                 "and DateEarned = @dateEarned";

                MySqlCommand deleteCommand1 = new MySqlCommand(deleteStatement1, conn);
                deleteCommand1.Parameters.AddWithValue("@ID", delEarning.ID);
                deleteCommand1.Parameters.AddWithValue("@amount", delEarning.Amount);
                deleteCommand1.Parameters.AddWithValue("@dateEarned", delEarning.DateEarned);

                // delete record
                string deleteStatement2 = "DELETE from records WHERE RecordID = @ID " +
                                                               "and BudgetID = @bID " +
                                                               "and RecordType = @recType " +
                                                               "and Title = @title " +
                                                               "and Description = @desc " +
                                                               "and DateCreated = @dateCreated";

                MySqlCommand deleteCommand2 = new MySqlCommand(deleteStatement2, conn);
                deleteCommand2.Parameters.AddWithValue("@ID", delEarning.ID);
                deleteCommand2.Parameters.AddWithValue("@bID", delEarning.BudgetID);
                deleteCommand2.Parameters.AddWithValue("@recType", delEarning.RecordType);
                deleteCommand2.Parameters.AddWithValue("@title", delEarning.Title);
                deleteCommand2.Parameters.AddWithValue("@desc", delEarning.Description);
                deleteCommand2.Parameters.AddWithValue("@dateCreated", delEarning.DateCreated);

                conn.Open();
                delEarningTran = conn.BeginTransaction();
                deleteCommand1.Transaction = delEarningTran;
                deleteCommand2.Transaction = delEarningTran;

                int isEarningDeleted = deleteCommand1.ExecuteNonQuery();
                if (isEarningDeleted > 0)
                {
                    int isRecordDeleted = deleteCommand2.ExecuteNonQuery();
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
