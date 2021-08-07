using ContactAppLib.Data;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace ContactAppLib.Service
{
    public class SqlDatabaseService : IContactService
    {
        private SqlConnection _sqlConnection;
        public SqlDatabaseService()
        {
            _sqlConnection = new SqlConnection(ConfigurationManager.AppSettings.Get("connectionString"));
        }
        public void AddContact(Contact contact)
        {
            SqlCommand contactSqlCommand, addressSqlCommand;
            SqlTransaction sqlTransaction;
            Guid guid;

            _sqlConnection.Open();
            guid = GetGuidOfName(contact.Name);
            sqlTransaction = _sqlConnection.BeginTransaction();

            contactSqlCommand = new SqlCommand("INSERT INTO CONTACT VALUES (@ContactID,@Name,@ContactNo)",_sqlConnection);
            contactSqlCommand.Transaction = sqlTransaction;
            contactSqlCommand.Parameters.Add(new SqlParameter("@ContactID", contact.Guid));
            contactSqlCommand.Parameters.Add(new SqlParameter("@Name", contact.Name));
            contactSqlCommand.Parameters.Add(new SqlParameter("@ContactNo", contact.ContactNo));

            addressSqlCommand = new SqlCommand("INSERT INTO ADDRESS VALUES (@ContactID, @Address)", _sqlConnection);
            addressSqlCommand.Transaction = sqlTransaction;
            addressSqlCommand.Parameters.Add(new SqlParameter("@Address", contact.Addresses[0].AddressData));
            if (guid != Guid.Empty)
            {
                addressSqlCommand.Parameters.Add(new SqlParameter("@ContactID", guid));
                addressSqlCommand.ExecuteNonQuery();
                sqlTransaction.Commit();
                _sqlConnection.Close();
                return;
            }

            addressSqlCommand.Parameters.Add(new SqlParameter("@ContactID", contact.Guid));

            try
            {
                int noOfRowsAffectedInContact, noOfRowsAffectedInAddress;
                noOfRowsAffectedInContact = contactSqlCommand.ExecuteNonQuery();
                noOfRowsAffectedInAddress = addressSqlCommand.ExecuteNonQuery();
                if (noOfRowsAffectedInContact < 1 || noOfRowsAffectedInAddress < 1)
                {
                    throw new Exception("All Commands not Excecuted Properly");
                }
                sqlTransaction.Commit();
            }catch(Exception exception)
            {
                Console.WriteLine(exception.Message);
                sqlTransaction.Rollback();
                _sqlConnection.Close();
            }

            _sqlConnection.Close();
        }

        private Guid GetGuidOfName(string name)
        {
            SqlCommand sqlCommand;
            SqlDataReader sqlDataReader;
            Guid guid;

            sqlCommand = new SqlCommand("SELECT CONTACT_ID FROM CONTACT WHERE NAME =@Name; ", _sqlConnection);
            sqlCommand.Parameters.Add(new SqlParameter("@Name",name));

            sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                guid = sqlDataReader.GetGuid(0);
                sqlDataReader.Close();
                return guid;
            }
            sqlDataReader.Close();
            return Guid.Empty;
        }

        public List<Address> GetAddresses(Guid contactID)
        {
            List<Address> addresses = new List<Address>();
            SqlCommand sqlCommand;
            SqlDataReader sqlDataReader;

            _sqlConnection.Open();

            sqlCommand = new SqlCommand("SELECT ADDRESS FROM ADDRESS WHERE CONTACT_ID=@ContactID;", _sqlConnection);
            sqlCommand.Parameters.Add(new SqlParameter("@ContactID",contactID));

            sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Address address = ReadAddressRow(sqlDataReader);
                addresses.Add(address);
            }

            _sqlConnection.Close();
            return addresses;
        }

        public List<Contact> GetContacts()
        {
            List<Contact> contacts = new List<Contact>();
            SqlCommand sqlCommand;
            SqlDataReader sqlDataReader;

            _sqlConnection.Open();

            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "SELECT CONTACT_ID, NAME, CONTACT_NO FROM CONTACT ";
            sqlCommand.Connection = _sqlConnection;

            sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Contact contact = ReadContactWithoutAddressRow(sqlDataReader);
                contacts.Add(contact);
            }
            sqlDataReader.Close();
            _sqlConnection.Close();
            return contacts;
        }

        public List<Contact> GetContactsWithAddress()
        {
            List<Contact> contacts = new List<Contact>();
            SqlCommand sqlCommand;
            SqlDataReader sqlDataReader;

            _sqlConnection.Open();

            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "SELECT CONTACT_ID, NAME, CONTACT_NO, ADDRESS ";
            sqlCommand.CommandText += "FROM";
            sqlCommand.CommandText += "(SELECT CONTACT.CONTACT_ID, CONTACT.NAME, CONTACT.CONTACT_NO, ADDRESS.ADDRESS, ROW_NUMBER() OVER(PARTITION BY CONTACT.NAME ORDER BY CONTACT.CONTACT_ID DESC) rn ";
            sqlCommand.CommandText += "FROM CONTACT LEFT JOIN ADDRESS ON CONTACT.CONTACT_ID = ADDRESS.CONTACT_ID) AS X WHERE rn = 1; ";
            sqlCommand.Connection = _sqlConnection;

            sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Contact contact = ReadContactRow(sqlDataReader);
                contacts.Add(contact);
            }
            sqlDataReader.Close();
            _sqlConnection.Close();
            return contacts;
        }

        private Contact ReadContactRow(SqlDataReader sqlDataReader)
        {
            Contact contact;
            contact = new Contact(sqlDataReader.GetGuid(0), Convert.ToString(sqlDataReader.GetValue(1)), Convert.ToDouble(sqlDataReader.GetValue(2)), sqlDataReader.GetString(3));
            return contact;
        }

        private Contact ReadContactWithoutAddressRow(SqlDataReader sqlDataReader)
        {
            Contact contact;
            contact = new Contact(sqlDataReader.GetGuid(0), Convert.ToString(sqlDataReader.GetValue(1)), Convert.ToDouble(sqlDataReader.GetValue(2)));
            return contact;
        }

        private Address ReadAddressRow(SqlDataReader sqlDataReader)
        {
            Address address;
            address = new Address(sqlDataReader.GetString(0));
            return address;
        }
    }
}
