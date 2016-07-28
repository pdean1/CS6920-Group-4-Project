using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace CS6920Group4Project.DAL
{
    /// <summary>
    /// Allows us to open a connection to a MySQL Database
    /// </summary>
    class DBConnect
    {
        private MySqlConnection connection;
        public const String database = "sql5123046";
        private String server;
        private String uid;
        private String password;

        /// <summary>
        /// Constructs a DBConnect Object
        /// </summary>
        public DBConnect()
        {
            Initialize();
        }

        /// <summary>
        /// Inits a DBConnect Object
        /// </summary>
        private void Initialize()
        {
            server = "127.0.0.1";
            /// modify these values as you wish
            uid = "root";
            password = "sesame";
          //  password = "password";
            /// END
            string connection_string;
            connection_string =
                "SERVER=" + server + ";" +
                "DATABASE=" + database + ";" +
                "UID=" + uid + ";" +
                "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connection_string);
        }

        /// <summary>
        /// Opens up a connection to the database
        /// </summary>
        /// <returns>
        /// Returns true on successfully opening a connection to the database, 
        /// false otherwise
        /// </returns>
        /// 
        /*
        private bool OpenConnection()
        {
            if (connection == null)
            {
                return false;
            }
            try
            {
                connection.Open();
                Console.Write("Successful connection to: " + server + " TIME: " 
                    + DateTime.Now.ToString("h:mm:ss tt"));
                return true;
            }
            catch (MySqlException e)
            {
                switch (e.Number)
                {
                    case 0:
                        Console.Write("Cannot connect to server: " + server 
                            + ".  Contact administrator");
                        break;
                    case 1045:
                        Console.Write("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }
        */
        /// <summary>
        /// Closes a connection to the database
        /// </summary>
        /// <returns>
        /// Returns true on successfully closing a connection to the database, 
        /// false otherwise
        /// </returns>
        /// 
        /*
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error attempting to close the MySQL Connection" 
                    + " Message:\n" + ex.Message);
                return false;
            }
        }
        */
        /// <summary>
        /// Returns the MySQL Connection to the Budget Database
        /// </summary>
        /// <returns>A MySQL Connection for the Database</returns>
        public MySqlConnection GetConnection()
        {
            return this.connection;
        }
    }
}
