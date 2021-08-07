using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransactionApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.AppSettings.Get("connectionString"));
            SqlTransaction sqlTransaction;
            SqlCommand customerCommand = new SqlCommand("UPDATE CUSTOMER SET BALANCE=BALANCE-5000 WHERE CUSTOMER_ID=200", sqlConnection);
            SqlCommand merchantCommand = new SqlCommand("UPDATE MERCHANT SET BALANCE=BALANCE-5000 WHERE MERCHANT_ID=300", sqlConnection);

            sqlConnection.Open();
            sqlTransaction = sqlConnection.BeginTransaction();
            customerCommand.Transaction = sqlTransaction;
            merchantCommand.Transaction = sqlTransaction;

            try
            {
                int noOfRowsAffectedInCustomer, noOfRowsAffectedInMerchant;
                noOfRowsAffectedInCustomer = customerCommand.ExecuteNonQuery();
                noOfRowsAffectedInMerchant = merchantCommand.ExecuteNonQuery();
                if(noOfRowsAffectedInCustomer < 1 || noOfRowsAffectedInMerchant < 1)
                {
                    throw new Exception("All Commands Not Executed Properly");
                }
                sqlTransaction.Commit();
            }
            catch(Exception exception)
            {
                Console.WriteLine(exception.Message);
                sqlTransaction.Rollback();
            }

            customerCommand.Dispose();
            merchantCommand.Dispose();
            sqlConnection.Close();
        }
    }
}
