using System;

namespace EmployeeAnalyzerApp.DataAccess
{
    public class Employee
    {
        private int _id, _managerId, _departmentNumber;
        private String _employeeName, _employeeDesignation, _dateOfJoining;
        private double _salary, _commission;

        public Employee(int id, String employeeName, String employeeDesignation, int managerId, String dateOfJoining, double salary, double commission, int departmentNumber)
        {
            _id = id;
            _employeeName = employeeName;
            _employeeDesignation = employeeDesignation;
            _managerId = managerId;
            _dateOfJoining = dateOfJoining;
            _salary = salary;
            _commission = commission;
            _departmentNumber = departmentNumber;
        }

        public int Id
        {
            get { return _id; }
        }
        public String EmployeeName
        {
            get { return _employeeName; }
        }
        public String EmployeeDesignation
        {
            get { return _employeeDesignation; }
        }
        public int ManagerId
        {
            get { return _managerId; }
        }
        public String DateOfJoining
        {
            get { return _dateOfJoining; }
        }
        public double Salary
        {
            get { return _salary; }
        }
        public double Commission
        {
            get { return _commission; }
        }
        public int DepartmentNumber
        {
            get { return _departmentNumber; }
        }
    }
}
