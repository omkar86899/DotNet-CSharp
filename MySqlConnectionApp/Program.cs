using MySql.Data.MySqlClient;
using System;
using System.Configuration;

namespace MySqlConnectionApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            String connectionString = ConfigurationManager.AppSettings.Get("connectionString");
            MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
            try
            {
                mySqlConnection.Open();
                Console.WriteLine("Server Name: " + mySqlConnection.DataSource);
                Console.WriteLine("Database Name: " + mySqlConnection.Database);
                Console.WriteLine("Connection Timeout: " + mySqlConnection.ConnectionTimeout);
                Console.WriteLine("Connection State: " + mySqlConnection.State);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            finally
            {
                if (mySqlConnection.State.Equals("Open"))
                {
                    mySqlConnection.Close();
                }
            }
        }
    }
}
