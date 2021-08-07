using System;
using System.Configuration;
using System.Data.SqlClient;

namespace CommandApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.AppSettings.Get("connectionString"));
            try
            {
                SqlCommand sqlCommand = new SqlCommand();
                int noOfRowsAffected;

                sqlConnection.Open();
                sqlCommand.Connection = sqlConnection;
                //SELECT
                DisplayEMPTable(sqlCommand);

                //INSERT
                Console.WriteLine("\nInserting Data .......");
                sqlCommand.CommandText = "INSERT INTO EMP VALUES (7952,'OMKAR','MANAGER',7839,'1-FEB-99',2500,NULL,30);";
                noOfRowsAffected = sqlCommand.ExecuteNonQuery();
                Console.WriteLine(noOfRowsAffected + " row Affected");
                Console.WriteLine("Data After Insertion: ");
                DisplayEMPTable(sqlCommand);

                //UPDATE
                Console.WriteLine("\nUpdating Data .......");
                sqlCommand.CommandText = "UPDATE EMP SET HIREDATE='3-FEB-99' WHERE ENAME='OMKAR';";
                noOfRowsAffected = sqlCommand.ExecuteNonQuery();
                Console.WriteLine(noOfRowsAffected + " row Affected");
                Console.WriteLine("Data After Updatetion: ");
                DisplayEMPTable(sqlCommand);

                //DELETE
                Console.WriteLine("\nDeleting Data .......");
                sqlCommand.CommandText = "DELETE FROM EMP WHERE ENAME='OMKAR';";
                noOfRowsAffected = sqlCommand.ExecuteNonQuery();
                Console.WriteLine(noOfRowsAffected + " row Affected");
                Console.WriteLine("Data After Deletion: ");
                DisplayEMPTable(sqlCommand);

                sqlCommand.Dispose();
            }
            catch (Exception exception)
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

        private static void DisplayEMPTable(SqlCommand sqlCommand)
        {
            SqlDataReader sqlDataReader;
            sqlCommand.CommandText = "SELECT * FROM EMP;";
            sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                PrintRow(sqlDataReader);
            }
            sqlDataReader.Close();
        }

        private static void PrintRow(SqlDataReader sqlDataReader)
        {
            for(int i = 0; i < sqlDataReader.FieldCount; i++)
            {
                Console.Write(sqlDataReader.GetValue(i)+" ");
            }
            Console.WriteLine();
        }
    }
}
