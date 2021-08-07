using System;

namespace EmployeePolymorphismApp.Model
{
    public abstract class Employee
    {
        private int _employeeNo;
        private String _employeeName;
        protected double _basic;

        public Employee(int employeeNo, String employeeName, double basic)
        {
            _employeeNo = employeeNo;
            _employeeName = employeeName;
            _basic = basic;
        }

        public int EmployeeNo
        {
            get { return _employeeNo; }
        }
        public String EmployeeName
        {
            get { return _employeeName; }
        }
        public double Basic
        {
            get { return _basic; }
        }

        public abstract double CalculateCTC();
        public abstract String GenerateSalarySlip();

    }
}
