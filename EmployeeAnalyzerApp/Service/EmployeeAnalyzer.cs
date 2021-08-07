using System;
using System.Collections.Generic;
using EmployeeAnalyzerApp.DataAccess;

namespace EmployeeAnalyzerApp.Service
{
    public class EmployeeAnalyzer
    {
        private List<Employee> _employees;
        public EmployeeAnalyzer(List<Employee> employees)
        {
            _employees = employees;
        }

        public Employee GetMaximumSalariedEmployee()
        {
            double maxSalary = 0;
            Employee maxSalariedEmployee = null;
            foreach(Employee employee in _employees)
            {
                if (employee.Salary > maxSalary)
                {
                    maxSalary = employee.Salary;
                    maxSalariedEmployee = employee;
                }
            }
            return maxSalariedEmployee;
        }

        public Dictionary<String, int> GetNumberOfEmployeesBasedOnDesignation()
        {
            Dictionary<string, int> employeeDesignationMap = new Dictionary<string, int>();
            foreach(Employee employee in _employees)
            {
                if (employeeDesignationMap.ContainsKey(employee.EmployeeDesignation))
                {
                    employeeDesignationMap[employee.EmployeeDesignation] += 1;
                }
                else
                {
                    employeeDesignationMap.Add(employee.EmployeeDesignation, 1);
                }
            }
            return employeeDesignationMap;
        }

        public Dictionary<int, int> GetNumberOfEmployeesBasedOnDepartmentNo()
        {
            Dictionary<int, int> employeeDepartmenMap = new Dictionary<int, int>();
            foreach (Employee employee in _employees)
            {
                if (employeeDepartmenMap.ContainsKey(employee.DepartmentNumber))
                {
                    employeeDepartmenMap[employee.DepartmentNumber] += 1;
                }
                else
                {
                    employeeDepartmenMap.Add(employee.DepartmentNumber, 1);
                }
            }
            return employeeDepartmenMap;
        }
    }
}
