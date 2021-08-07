using System;
using System.Text;

namespace EmployeePolymorphismApp.Model
{
    public class Manager:Employee
    {
        private double _hra = 50, _ta = 40;

        public Manager(int employeeNo, String employeeName, double basic) : base(employeeNo, employeeName, basic)
        {

        }

        public override double CalculateCTC()
        {
            return _basic + _basic * ((_hra + _ta) / 100);
        }

        public override string GenerateSalarySlip()
        {
            StringBuilder salarySlip = new StringBuilder("");
            salarySlip.Append("HRA: " + _hra + "%");
            salarySlip.Append(",TA: " + _ta + "%");
            return salarySlip.ToString();
        }
    }
}
