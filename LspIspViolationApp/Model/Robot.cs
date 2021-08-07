using System;

namespace LspIspViolationApp.Model
{
    public class Robot : IWorker
    {
        public void startEat()
        {
            throw new Exception("Robot Don't Eat.");
        }

        public void startWork()
        {
            Console.WriteLine("Robot start Working..");
        }

        public void stopEat()
        {
            throw new Exception("Robots Dont Eat.");
        }

        public void stopWork()
        {
            Console.WriteLine("Robot stopped work.");
        }
    }
}
