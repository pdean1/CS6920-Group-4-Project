using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace CS6920Group4Project.Utilities
{
    /// <summary>
    /// Functions that inform the user of a database issue go in the class
    /// </summary>
    public static class DatabaseErrorMessageUtility
    {
        /// <summary>
        /// This function presensts a message box to the user informing them there was an error with the database.
        /// This function should only be called if and only if you encountered a database error that threw an exception.
        /// </summary>
        /// <param name="message">Customizable portion of the message to send to the user</param>
        /// <param name="e">MySqlException that was thrown</param>
        public static void SendMessageToUser(string message, MySqlException e)
        {
            MessageBox.Show(message + "\n" + "Error Information: \n\tError Number:" + e.Number + "\n\tError Message:" + e.Message);
        }
    }
}
