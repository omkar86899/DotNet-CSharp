using System;

namespace LspIspSolutionApp.Model
{
    public class Robot : IWorkable
    {
        public void startWork()
        {
            Console.WriteLine("Robot start Working..");
        }

        public void stopWork()
        {
            Console.WriteLine("Robot stopped work.");
        }
    }
}
