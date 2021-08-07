using System;
using System.Collections.Generic;
using ContactsApp.Data;

namespace ContactsApp.Presentation
{
    public class ContactsConsole
    {
        public ContactsConsole()
        {
            startConsole();
        }

        private void startConsole()
        {
            int choice;
            IContactsLoader contactsLoader = new DatabaseLoader();
            do
            {
                Console.WriteLine("1.Display Contacts\n2.Add Contact\n3.Exit");
                Console.WriteLine("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    displayContacts(contactsLoader);
                }
                if(choice == 2)
                {
                    addContact(contactsLoader);
                }
            } while (choice!=3);
        }

        private void addContact(IContactsLoader contactsLoader)
        {
            String name;
            double mobileNumber;
            Console.WriteLine("Enter Name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter Mobile Number: ");
            mobileNumber = Convert.ToDouble(Console.ReadLine());
            contactsLoader.AddContact(new Contact(name, mobileNumber));
        }

        private void displayContacts(IContactsLoader contactsLoader)
        {
            List<Contact> contacts = contactsLoader.GetContacts();
            foreach(Contact contact in contacts)
            {
                Console.WriteLine("Name: " + contact.Name);
                Console.WriteLine("Mobile Number: " + contact.MobileNumber);
            }
        }
    }
}
