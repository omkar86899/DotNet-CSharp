using System;
using System.Collections.Generic;

namespace ContactsApp.Data
{
    public interface IContactsLoader
    {
        void AddContact(Contact contact);

        List<Contact> GetContacts();
    }
}
