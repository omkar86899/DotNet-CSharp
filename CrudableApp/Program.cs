using CrudableApp.Model;

namespace CrudableApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            ICrudable customerDB, departmentDB, invoiceDB;
            customerDB = new CustomerDB();
            departmentDB = new DepartmentDB();
            invoiceDB = new InvoiceDB();
            DoDatabaseOperations(customerDB);
            DoDatabaseOperations(departmentDB);
            DoDatabaseOperations(invoiceDB);
        }

        private static void DoDatabaseOperations(ICrudable crudable)
        {
            crudable.Create();
            crudable.Read();
            crudable.Update();
            crudable.Delete();
        }
    }
}
