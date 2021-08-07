using System;
using System.Configuration;
using System.Data.SqlClient;

namespace SqlInjectionApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.AppSettings.Get("connectionString"));
            SqlCommand sqlCommand;
            SqlDataReader sqlDataReader;
            String empNo;
            sqlConnection.Open();
            Console.WriteLine("Enter Employee no: ");
            empNo = Console.ReadLine();
            sqlCommand = new SqlCommand("SELECT * FROM EMP WHERE EMPNO=" + empNo, sqlConnection);
            sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                PrintTable(sqlDataReader);
            }
            sqlCommand.Dispose();
            sqlDataReader.Close();
            sqlConnection.Close();
        }

        private static void PrintTable(SqlDataReader sqlDataReader)
        {
            for (int i = 0; i < 8; i++)
            {
                Console.Write(sqlDataReader.GetValue(i) + " ");
            }
            Console.WriteLine();
        }
    }
}
