using System;

namespace LspIspViolationApp.Model
{
    public interface IWorker
    {
        void startWork();
        void stopWork();
        void startEat();
        void stopEat();
    }
}
