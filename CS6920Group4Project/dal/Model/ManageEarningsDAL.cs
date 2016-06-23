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

    }
}
