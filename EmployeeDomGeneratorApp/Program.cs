using EmployeePolymorphismApp.Model;
using EmpoyeeDomGeneratorApp.View;

namespace EmpoyeeDomGeneratorApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            Employee developer, manager, analyst;
            developer = new Developer(10, "omkar", 20000);
            manager = new Manager(11, "sagar", 30000);
            analyst = new Analyst(12, "vishal", 15000);
            HTMLFileGenerator domGenerator = new HTMLFileGenerator();
            domGenerator.GenerateHTMLFile(developer);
            domGenerator.GenerateHTMLFile(manager);
            domGenerator.GenerateHTMLFile(analyst);
        }
    }
}
