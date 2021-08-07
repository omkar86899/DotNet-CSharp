using System;
using LspIspSolutionApp.Model;

namespace LspIspSolutionApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            IWorker employee = new Employee();
            IWorkable robot = new Robot();

            AtCompany(employee);
            AtCanteen(employee);
            AtCompany(robot);
        }

        private static void AtCanteen(IEatable worker)
        {
            worker.startEat();
            worker.stopEat();
        }

        private static void AtCompany(IWorkable worker)
        {
            worker.startWork();
            worker.startWork();
        }
    }
}
