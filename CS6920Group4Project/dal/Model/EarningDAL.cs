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


        public static void EditEarnings(Earning earn) 
        {
            MySqlConnection connection = new DBConnect().GetConnection();

            String editEarningsStatement = "UPDATE sql5123046.earnings (`RecordID`, `Amount`, `DateEarned`)" +
                                                "SET (RecordID, @Amount, @DateEarned)" +
                                                    " WHERE `RecordID` = @RecordID";

            MySqlCommand editEarnCommand = new MySqlCommand(editEarningsStatement, connection);

            editEarnCommand.Parameters.AddWithValue("@RecordID", earn.ID);
            editEarnCommand.Parameters.AddWithValue("@Amount", earn.Amount);
            editEarnCommand.Parameters.AddWithValue("@DateEarned", earn.DateEarned.ToString("yyyy-MM-dd hh:mm:ss"));

            try
            {
                connection.Open();
                editEarnCommand.ExecuteNonQuery();
        
            }
            catch (MySqlException ex)
            {
                DatabaseErrorMessageUtility.SendMessageToUser("Unable to update earnings in the database.", ex);
            }
            catch (Exception ex)
            {
                DatabaseErrorMessageUtility.SendMessageToUser("Unable to update earnings in the database.", ex);
            }
            finally 
            {
                editEarnCommand.Dispose();
                connection.Close();
            }



    }
    }
}
