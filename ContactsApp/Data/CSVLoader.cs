using System;
using System.Collections.Generic;
using System.IO;

namespace ContactsApp.Data
{
    public class CSVLoader:IContactsLoader
    {
        private String _fileName;

        public CSVLoader(String filename)
        {
            _fileName = filename;
        }

        public void AddContact(Contact contact)
        {
            StreamWriter streamWriter = File.AppendText(_fileName);
            streamWriter.WriteLine(contact.Name+","+contact.MobileNumber);
            streamWriter.Flush();
            streamWriter.Close();
        }

        public List<Contact> GetContacts()
        {
            StreamReader streamReader = File.OpenText(_fileName);
            List<Contact> contacts = new List<Contact>();
            while (streamReader.Peek() > -1)
            {
                String[] contact = streamReader.ReadLine().Split(',');
                int nameIndex = 0, mobileNumberIndex = 1;
                contacts.Add(new Contact(contact[nameIndex], Convert.ToDouble(contact[mobileNumberIndex])));
            }
            streamReader.Close();
            return contacts;
        }
    }
}
