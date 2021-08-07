using MySql.Data.MySqlClient;
using System;
using System.Configuration;

namespace MySqlCommandApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(ConfigurationManager.AppSettings.Get("connectionString"));
            try
            {
                MySqlCommand mySqlCommand = new MySqlCommand();
                int noOfRowsAffected;

                mySqlConnection.Open();
                mySqlCommand.Connection = mySqlConnection;
                //SELECT
                DisplayEMPTable(mySqlCommand);

                //INSERT
                Console.WriteLine("\nInserting Data .......");
                mySqlCommand.CommandText = "INSERT INTO EMP VALUES (7952,'OMKAR','MANAGER',7839,'1999-2-1',2500,NULL,30);";
                noOfRowsAffected = mySqlCommand.ExecuteNonQuery();
                Console.WriteLine(noOfRowsAffected + " row Affected");
                Console.WriteLine("Data After Insertion: ");
                DisplayEMPTable(mySqlCommand);

                //UPDATE
                Console.WriteLine("\nUpdating Data .......");
                mySqlCommand.CommandText = "UPDATE EMP SET HIREDATE='1999-2-3' WHERE ENAME='OMKAR';";
                noOfRowsAffected = mySqlCommand.ExecuteNonQuery();
                Console.WriteLine(noOfRowsAffected + " row Affected");
                Console.WriteLine("Data After Updatetion: ");
                DisplayEMPTable(mySqlCommand);

                //DELETE
                Console.WriteLine("\nDeleting Data .......");
                mySqlCommand.CommandText = "DELETE FROM EMP WHERE ENAME='OMKAR';";
                noOfRowsAffected = mySqlCommand.ExecuteNonQuery();
                Console.WriteLine(noOfRowsAffected + " row Affected");
                Console.WriteLine("Data After Deletion: ");
                DisplayEMPTable(mySqlCommand);

                mySqlCommand.Dispose();
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
        private static void DisplayEMPTable(MySqlCommand mySqlCommand)
        {
            MySqlDataReader mySqlDataReader;
            mySqlCommand.CommandText = "SELECT * FROM EMP;";
            mySqlDataReader = mySqlCommand.ExecuteReader();
            while (mySqlDataReader.Read())
            {
                PrintRow(mySqlDataReader);
            }
            mySqlDataReader.Close();
        }

        private static void PrintRow(MySqlDataReader mySqlDataReader)
        {
            for (int i = 0; i < mySqlDataReader.FieldCount; i++)
            {
                Console.Write(mySqlDataReader.GetValue(i) + " ");
            }
            Console.WriteLine();
        }
    }
}
