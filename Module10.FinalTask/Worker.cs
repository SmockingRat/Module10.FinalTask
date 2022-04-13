using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10.FinalTask
{
    public class Worker: IWorker
    {

        public ILogger Logger { get; }

        public Worker(ILogger logger)
        {
            Logger = logger;
        }

        public void Work()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Logger.Event("Происходит вычисление");
            Console.ForegroundColor = ConsoleColor.White;
        }

        
    }

    public class Worker2 : IWorker
    {

        ILogger Logger { get; }

        public Worker2(ILogger logger)
        {
            Logger = logger;
        }

        public void Work()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Logger.Event("Вычисление завершено");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }

    public class ErrorWorker : IWorker
    {

        public ILogger Logger { get; }

        public ErrorWorker(ILogger logger)
        {
            Logger = logger;
        }

        public void Work()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Logger.Error("Вы не ввели требуемые значения!");
        }


    }


}
