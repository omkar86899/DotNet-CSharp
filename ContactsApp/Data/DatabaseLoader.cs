using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace ContactsApp.Data
{
    class DatabaseLoader : IContactsLoader
    {
        private SqlConnection _sqlConnection;

        public DatabaseLoader()
        {
            _sqlConnection = new SqlConnection(ConfigurationManager.AppSettings.Get("connectionString"));
        }

        public void AddContact(Contact contact)
        {
            _sqlConnection.Open();
            using (SqlCommand sqlCommand = _sqlConnection.CreateCommand())
            {
                sqlCommand.CommandText = "INSERT INTO CONTACT VALUES('" + contact.Name + "', " + contact.MobileNumber + "); ";
                sqlCommand.ExecuteNonQuery();
            }
            _sqlConnection.Close();
        }

        public List<Contact> GetContacts()
        {
            List<Contact> contacts;
            _sqlConnection.Open();
            using (SqlCommand sqlCommand = _sqlConnection.CreateCommand())
            {
                sqlCommand.CommandText = "SELECT * FROM CONTACT;";
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                contacts = ReadTable(sqlDataReader);
            }
            _sqlConnection.Close();
            return contacts;
        }

        private List<Contact> ReadTable(SqlDataReader sqlDataReader)
        {
            List<Contact> contacts = new List<Contact>();
            while (sqlDataReader.Read())
            {
                Contact contact = ReadRow(sqlDataReader);
                contacts.Add(contact);
            }
            return contacts;
        }

        private Contact ReadRow(SqlDataReader sqlDataReader)
        {
            Contact contact = new Contact(sqlDataReader.GetString(0), Convert.ToDouble(sqlDataReader.GetValue(1)));
            return contact;
        }
    }
}