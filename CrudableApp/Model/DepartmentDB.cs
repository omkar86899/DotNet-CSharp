using System;

namespace CrudableApp.Model
{
    public class DepartmentDB : ICrudable
    {
        public void Create()
        {
            Console.WriteLine("Creating Department Database");
        }

        public void Delete()
        {
            Console.WriteLine("Deleting Department Database");
        }

        public void Read()
        {
            Console.WriteLine("Reading Department Database");
        }

        public void Update()
        {
            Console.WriteLine("Updating Department Database");
        }
    }
}
