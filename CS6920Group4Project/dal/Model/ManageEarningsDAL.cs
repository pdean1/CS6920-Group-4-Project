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

    }
}
