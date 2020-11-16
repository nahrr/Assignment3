using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace Assignment3.Models
{
    public static class DbConnection
    {
        static MySqlConnection databaseConnection = null;
        public static MySqlConnection getDBConnection()
        {
            if (databaseConnection == null)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["dbConn"].ConnectionString;
                databaseConnection = new MySqlConnection(connectionString);

                try
                {
                    databaseConnection.Open();
                    Console.WriteLine("Connection established");
                    databaseConnection.Close();
                    Console.WriteLine("Connection closed");
                }

                catch (Exception ex)
                {
                    Console.WriteLine("Connection failed");
                }

            }
            return databaseConnection;
        }

    }
}
