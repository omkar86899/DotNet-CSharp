using System;
using System.Text;

namespace EmployeePolymorphismApp.Model
{
    public class Developer : Employee
    {
        private double _projectAllowance = 40, _personalAllowance=30;

        public Developer(int employeeNo, String employeeName, double basic):base(employeeNo, employeeName, basic)
        {

        }

        public override double CalculateCTC()
        {
            return _basic + _basic*((_personalAllowance+_projectAllowance)/100);
        }

        public override String GenerateSalarySlip()
        {
            StringBuilder salarySlip = new StringBuilder("");
            salarySlip.Append("Project Allowance: " + _projectAllowance + "%");
            salarySlip.Append(",Personal Allowance: " + _personalAllowance + "%");
            return salarySlip.ToString();

        }
    }
}
