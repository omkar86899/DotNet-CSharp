using System;
using System.Collections.Generic;
using ContactAppLib.Data;

namespace ContactAppLib.Service
{
    public interface IContactService
    {
        List<Contact> GetContacts();
        List<Contact> GetContactsWithAddress();
        List<Address> GetAddresses(Guid contactID);
        void AddContact(Contact contact);
    }
}
