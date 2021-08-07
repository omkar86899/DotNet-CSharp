using System;

namespace LspIspViolationApp.Model
{
    public class Employee : IWorker
    {
        public void startEat()
        {
            Console.WriteLine("Employee Start Eating..");
        }

        public void startWork()
        {
            Console.WriteLine("Employee Start Working..");
        }

        public void stopEat()
        {
            Console.WriteLine("Employee Stop Eating.");
        }

        public void stopWork()
        {
            Console.WriteLine("Employee stopped work.");
        }
    }
}
