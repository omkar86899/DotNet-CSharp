using System;
using System.Collections.Generic;
using System.IO;

namespace EmployeeAnalyzerApp.DataAccess
{
    public class FileLoader : IDataLoader
    {
        private StreamReader streamReader;
        private List<Employee> _employees;
        public FileLoader(String fileName)
        {
            streamReader = File.OpenText(fileName);
            _employees = new List<Employee>();
        }
        public List<Employee> GetEmployees()
        {
            while (streamReader.Peek() > -1)
            {
                String[] employeeArray = streamReader.ReadLine().Split(',');
                Employee employee = new Employee(ConvertToInt(employeeArray[0]), employeeArray[1].Replace("'", ""), employeeArray[2].Replace("'", ""), ConvertToInt(employeeArray[3]), employeeArray[4].Replace("'", ""), ConvertToDouble(employeeArray[5]), ConvertToDouble(employeeArray[6]), ConvertToInt(employeeArray[7]));
                if (!IsEmployeeExist(employee))
                {
                    _employees.Add(employee);
                }
            }
            return _employees;
        }

        private bool IsEmployeeExist(Employee employee)
        {
            foreach(Employee employee1 in _employees)
            {
                if(employee1.Id == employee.Id)
                {
                    return true;
                }
            }
            return false;
        }

        private double ConvertToDouble(string number)
        {
            if (number.Equals("NULL"))
            {
                return 0;
            }
            return Convert.ToDouble(number);
        }

        private int ConvertToInt(string number)
        {
            if(number.Equals("NULL"))
            {
                return 0;
            }
            return Convert.ToInt32(number);
        }
    }
}
