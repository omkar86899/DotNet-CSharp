using System;

namespace CrudableApp.Model
{
    public class InvoiceDB : ICrudable
    {
        public void Create()
        {
            Console.WriteLine("Creating Invoice Database");
        }

        public void Delete()
        {
            Console.WriteLine("Deleting Invoice Databse");
        }

        public void Read()
        {
            Console.WriteLine("Reading Invoice Database");
        }

        public void Update()
        {
            Console.WriteLine("Updating Invoice Databse");
        }
    }
}
