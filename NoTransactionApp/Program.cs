using System;
using System.Configuration;
using System.Data.SqlClient;

namespace NoTransactionApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.AppSettings.Get("connectionString"));
            SqlCommand customerCommand = new SqlCommand("UPDATE CUSTOMER SET BALANCE=BALANCE-5000 WHERE CUSTOMER_ID=200",sqlConnection);
            SqlCommand merchantCommand = new SqlCommand("UPDATE MERCHANT SET BALANCE=BALANCE-5000 WHERE MERCHANT_ID=300",sqlConnection);

            sqlConnection.Open();
            Console.WriteLine("{0} row affected in CUSTOMER table", customerCommand.ExecuteNonQuery());
            Console.WriteLine("{0} row affected in MERCHANT table", merchantCommand.ExecuteNonQuery());

            customerCommand.Dispose();
            merchantCommand.Dispose();
            sqlConnection.Close();
        }
    }
}