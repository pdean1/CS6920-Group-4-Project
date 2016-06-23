﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using CS6920Group4Project.Model;
using CS6920Group4Project.Utilities;

namespace CS6920Group4Project.DAL.Model
{
    public class EarningDAL
    {
        private MySqlConnection conn = new DBConnect().GetConnection();

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
    }
}
