using System;
using System.IO;
using System.Collections.Generic;
using EmployeePolymorphismApp.Model;
using EmpoyeeDomGeneratorApp.View.GroupTag;
using EmpoyeeDomGeneratorApp.View.IndividualTag;

namespace EmpoyeeDomGeneratorApp.View
{
    public class HTMLFileGenerator
    {
        public void GenerateHTMLFile(Employee employee)
        {
            String fileName = employee.EmployeeNo.ToString();
            FileStream file = new FileStream(fileName+".html", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter streamWriter = new StreamWriter(file);

            HTMLTag htmlTag = new HTMLTag();
            BodyTag bodyTag = new BodyTag();
            List<IHTMLGenerator> pTags = new List<IHTMLGenerator>();

            pTags.Add(new PTag("Employee Name: " + employee.EmployeeName));
            pTags.Add(new PTag("Employee Number: " + employee.EmployeeNo));
            pTags.Add(new PTag("Employee basic: " + employee.Basic));
            pTags.Add(new PTag("Employee CTC: " + employee.CalculateCTC()));
            pTags.Add(new PTag("Salary Slip: "));
            pTags.Add(new PTag(employee.GenerateSalarySlip()));

            foreach(PTag pTag in pTags)
            {
                bodyTag.AddChild(pTag);
            }
            htmlTag.AddChild(bodyTag);

            streamWriter.WriteLine(htmlTag.GenerateHTML());
            streamWriter.Flush();
            streamWriter.Close();
            file.Close();

        }
    }
}
