using System;
using EmployeePolymorphismApp.Model;

namespace EmployeePolymorphismApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            Employee developer, manager,analyst;
            developer = new Developer(10, "omkar", 20000);
            manager = new Manager(11, "sagar", 25000);
            analyst = new Analyst(12, "vishal", 15000);

            PrintEmployeeInfo(developer);
            PrintEmployeeInfo(manager);
            PrintEmployeeInfo(analyst);
        }

        private static void PrintEmployeeInfo(Employee employee)
        {
            Console.WriteLine("Name: " + employee.EmployeeName);
            Console.WriteLine("No: " + employee.EmployeeNo);
            Console.WriteLine("Basic: " + employee.Basic);
            Console.WriteLine("Total CTC: " + employee.CalculateCTC());
            Console.WriteLine("Salary Slip: \n" + employee.GenerateSalarySlip());
        }
    }
}
