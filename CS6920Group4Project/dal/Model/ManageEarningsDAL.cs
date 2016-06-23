using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using CS6920Group4Project.Model;
using CS6920Group4Project.DAL.Model;
using System.Windows.Forms;
using CS6920Group4Project.Utilities;

namespace CS6920Group4Project.DAL.Model
{
    class ManageEarningsDAL
    {
        /// <summary>
        /// connector for the manage earnings 
        /// </summary>
        private MySqlConnection conn = new DBConnect().GetConnection();

        /// <summary>
        /// create two insert statements, one for each table in the database
        /// </summary>
        String InsertEarningCategories = "INSERT INTO `sql5123046`.`earningscategories`" +
                                                "(`Title`,`Description`)" +
                                                "VALUES (@Title, @Description)";


        String InsertEarnings = "INSERT INTO `sql5123046`.`earnings`" +
                                        "(`Amount`, `DateEarned`) VALUES (@Amount, @DateEarned)";
        /// <summary>
        /// Method for the insertion of data into the two tables
        /// </summary>
        /// <param name="earn">earning data for amounts and dates</param>
        /// <param name="category">category from categoryEarnings</param>
        /// <returns>returns true if updated</returns>
        public Boolean InsertEarn(Earning earn, EarningCategory category)
        {
            try
            {
                MySqlCommand myCommand = new MySqlCommand();
                conn.Open();
                myCommand.Connection = conn;
                myCommand.CommandText = InsertEarnings;
                myCommand.Prepare();
                myCommand.Parameters.AddWithValue("@Amount", earn.Amount);
                myCommand.Parameters.AddWithValue("@DateEarned", earn.DateEarned);
                myCommand.ExecuteNonQuery();

                MySqlCommand mySecondCommand = new MySqlCommand();
                mySecondCommand.Connection = conn;
                mySecondCommand.CommandText = InsertEarningCategories;
                mySecondCommand.Prepare();
                mySecondCommand.Parameters.AddWithValue("@Title", category.Title);
                mySecondCommand.Parameters.AddWithValue("@Description", category.Description);
                mySecondCommand.ExecuteNonQuery();

            }
            catch (MySqlException exception)
            {
                DatabaseErrorMessageUtility.SendMessageToUser("Unable to add earnings to the database.", exception);
                return false;
            }
            finally
            {
                conn.Close();
            }
            return true;
        }
    }
}

