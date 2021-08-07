using System;
using LspIspViolationApp.Model;

namespace LspIspViolationApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            IWorker employee, robot;
            employee = new Employee();
            robot = new Robot();
            AtCompany(employee);
            AtCanteen(employee);
            AtCompany(robot);
            AtCanteen(robot);
        }

        private static void AtCanteen(IWorker worker)
        {
            try
            {
                worker.startEat();
                worker.stopEat();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void AtCompany(IWorker worker)
        {
            worker.startWork();
            worker.stopWork();
        }
    }
}
