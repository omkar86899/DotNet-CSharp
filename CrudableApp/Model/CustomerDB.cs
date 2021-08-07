using System;
namespace CrudableApp.Model
{
    public class CustomerDB : ICrudable
    {
        public void Create()
        {
            Console.WriteLine("Creating Customer Database");
        }

        public void Delete()
        {
            Console.WriteLine("Deleting Customer Database");
        }

        public void Read()
        {
            Console.WriteLine("Reading Customer Database");
        }

        public void Update()
        {
            Console.WriteLine("Updating Customer Database");
        }
    }
}
