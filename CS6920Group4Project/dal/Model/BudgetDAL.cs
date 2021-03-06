﻿using System;
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
    public class BudgetDAL
    {
        private MySqlConnection conn = new DBConnect().GetConnection();

        private const string InsertBudgetStatement = "";

        public long InsertBudget(Budget budget)
        {
            return 0;
        }

        private const string SelectAllUsersBudgetsStatement = "SELECT * FROM `sql5123046`.`budgets` WHERE `budgets`.`UserID` = @ID;";

        public List<Budget> GetAllUserBudgets (int UserID)
        {
            List<Budget> budgets = new List<Budget>();

            try
            {
                MySqlCommand cmd = new MySqlCommand();
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = SelectAllUsersBudgetsStatement;
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@ID", UserID);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Budget budget = new Budget();
                        budget.ID = reader.GetInt32(0);
                        budget.UserID = reader.GetInt32(1);
                        budget.Title = reader.GetString(2);
                        try
                        {
                            budget.Description = reader.GetString(3);
                        }
                        catch (Exception)
                        {
                            budget.Description = "";
                        }
                        
                        budget.DateCreated = reader.GetDateTime(4);
                        try
                        {
                            budget.Notes = reader.GetString(5);
                        }
                        catch (Exception)
                        {
                            budget.Notes = "";
                        }
                        budgets.Add(budget);
                    }
                }
            }
            catch (MySqlException e)
            {
                budgets = null;
            }
            catch (Exception e)
            {
                budgets = null;
            }
            finally
            {
                conn.Close();
            }
            return budgets;
        }

        public bool EditBudget(Budget budget)
        {
            bool update = false;

            MySqlConnection connection = new DBConnect().GetConnection();

            String updateBudgetsStatement = "UPDATE `sql5123046`.`budgets` " +
                                             "SET Title = @Title, Description = @Description, Notes = @Notes " +
                                             "where BudgetID = @BudgetID";

            MySqlCommand updateBudgetCommand = new MySqlCommand(updateBudgetsStatement, connection);

            updateBudgetCommand.Parameters.AddWithValue("@BudgetID", budget.ID);
            updateBudgetCommand.Parameters.AddWithValue("@Title", budget.Title);
            updateBudgetCommand.Parameters.AddWithValue("@Description", budget.Description);
            updateBudgetCommand.Parameters.AddWithValue("@Notes", budget.Notes);

            MySqlTransaction trans = null;
            try
            {
                connection.Open();
                trans = connection.BeginTransaction();

                updateBudgetCommand.Transaction = trans;

                int updateCode = updateBudgetCommand.ExecuteNonQuery();
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
            }
            catch (Exception ex)
            {
                trans.Rollback();
            }
            finally
            {
                updateBudgetCommand.Dispose();
                connection.Close();
            }
            return update;
        }

        private const string DeleteBudgetStatement = "DELETE FROM `sql5123046`.`budgets` WHERE `budgets`.`BudgetID` = @ID;";
        public Boolean DeleteBudget(int id)
        {
            var success = false;
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.CommandText = DeleteBudgetStatement;
                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@ID", id);
                    if (cmd.ExecuteNonQuery() != 0)
                    {
                        success = true;
                    }
                }
                catch (MySqlException e)
                {
                    success = false;
                }
                catch (Exception e)
                {
                    success = false;
                }
                finally
                {
                    conn.Close();
                }
            }
            return success;
        }

        private const string CreateBudgetStatment = "INSERT INTO `sql5123046`.`budgets` (`UserID`, `Title`, `Description`, `DateCreated`, `Notes`) " +
                                                        "VALUES (@ID, @Title, @Desc, @DateCreated, @Notes);";

        public bool CreateBudget(Budget budget)
        {
            try
                {
                    MySqlCommand cmd = new MySqlCommand();
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.CommandText = CreateBudgetStatment;
                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@ID", budget.UserID);
                    cmd.Parameters.AddWithValue("@Title", budget.Title);
                    cmd.Parameters.AddWithValue("@Desc", budget.Description);
                    cmd.Parameters.AddWithValue("@DateCreated", DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));
                    cmd.Parameters.AddWithValue("@Notes", budget.Notes);

                    int isCreated = cmd.ExecuteNonQuery();
                    if (isCreated > 0)
                        return true;
                    else
                        return false;

                }
                catch (MySqlException e)
                {
                    return false;
                }
                catch (Exception e)
                {
                    return false;
                }
                finally
                {
                    conn.Close();
                }
        }
    }
}
