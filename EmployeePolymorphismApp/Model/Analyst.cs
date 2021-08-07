using System;
using System.Text;

namespace EmployeePolymorphismApp.Model
{
    public class Analyst:Employee
    {
        private double _perks = 30;

        public Analyst(int employeeNo, String employeeName, double basic) : base(employeeNo, employeeName, basic)
        {

        }

        public override double CalculateCTC()
        {
            return _basic + _basic * (_perks / 100);
        }

        public override string GenerateSalarySlip()
        {
            StringBuilder salarySlip = new StringBuilder("");
            salarySlip.Append("Perks: " + _perks+"%");
            return salarySlip.ToString();
        }
    }
}
