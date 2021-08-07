using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlInjectionSolutionApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.AppSettings.Get("connectionString"));
            SqlCommand sqlCommand;
            SqlDataReader sqlDataReader;
            String deptNo;
            sqlConnection.Open();
            Console.WriteLine("Enter Department no: ");
            deptNo = Console.ReadLine();
            sqlCommand = new SqlCommand("SELECT * FROM EMP WHERE DEPTNO=@DeptNo",sqlConnection);
            SqlParameter sqlParameter = new SqlParameter("@DeptNo", deptNo);
            sqlCommand.Parameters.Add(sqlParameter);
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
