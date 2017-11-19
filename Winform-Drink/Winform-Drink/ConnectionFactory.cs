using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Winform_Drink
{
    public class ConnectionFactory
    {
        /* The ConnectionFactory class is used throughout the program to connect to the database. Instead of having to write out the credentials
         * and create a connection everytime, the line 'var connection = ConnectionFactory.Create();' is used in each function. This line makes
         * the variable 'connection' the connection string to the database.
         */
        public static MySqlConnection Create()
        {
            MySqlConnection connection;
            

            string connectionString = @"server=" + server + ";" + "UID=" + user + ";" + "password=" + password + ";" + "database=" + database + ";";
            connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();

            }
            // Exception Handling
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        break;

                    case 1045:
                        break;
                }
            }
            return connection;
        }
    }
}
