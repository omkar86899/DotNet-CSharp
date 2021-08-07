using System;
using System.Configuration;
using System.Data.SqlClient;

namespace ConnectionApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            String connectionString = ConfigurationManager.AppSettings.Get("connectionString");
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            try
            {
                sqlConnection.Open();
                Console.WriteLine("Server Name: "+sqlConnection.DataSource);
                Console.WriteLine("Databse Name: "+sqlConnection.Database);
                Console.WriteLine("Connection Timeout: "+sqlConnection.ConnectionTimeout);
                Console.WriteLine("Connection State: "+sqlConnection.State);
            }catch(Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            finally
            {
                if (sqlConnection.State.Equals("Open"))
                {
                    sqlConnection.Close();
                }
            }

        }
    }
}
