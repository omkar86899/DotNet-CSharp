using System;
using System.Collections.Generic;
using EmployeeAnalyzerApp.DataAccess;
using EmployeeAnalyzerApp.Service;

namespace EmployeeAnalyzerApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            IDataLoader dataLoader = new UrlLoader("http://swabhav-tech.firebaseapp.com/emp.txt");
            List<Employee> employees = dataLoader.GetEmployees();
            EmployeeAnalyzer employeeAnalyzer = new EmployeeAnalyzer(employees);
            Console.WriteLine("Max Salaried Employee: "+employeeAnalyzer.GetMaximumSalariedEmployee().EmployeeName);
            Console.WriteLine("Number of Employees Based On Designation:");
            foreach(KeyValuePair<String,int> keyValuePair in employeeAnalyzer.GetNumberOfEmployeesBasedOnDesignation())
            {
                Console.WriteLine("{0}:{1}", keyValuePair.Key, keyValuePair.Value);
            }
            Console.WriteLine("Number of Employees Based On Department Number:");
            foreach (KeyValuePair<int, int> keyValuePair in employeeAnalyzer.GetNumberOfEmployeesBasedOnDepartmentNo())
            {
                Console.WriteLine("{0}:{1}", keyValuePair.Key, keyValuePair.Value);
            }
        }
    }
}
