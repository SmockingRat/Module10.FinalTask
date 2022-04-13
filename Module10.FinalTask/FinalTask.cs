using System;

namespace Module10.FinalTask
{
    class FinalTask
    {

        static ILogger Logger { get; set; }

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите число 1");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите число 2");
                int b = Convert.ToInt32(Console.ReadLine());

                MyMath math = new MyMath();

                Logger = new Logger();

                var Work1 = new Worker(Logger);
                var Work2 = new Worker2(Logger);

                Work1.Work();
                math.PlusNumbers(a, b);
                Work2.Work();   
            }
            catch
            {
                Logger = new Logger();
                var err = new ErrorWorker(Logger);
                err.Work();
                
            }
            Console.ReadKey();
        }

        interface IPlus
        {
            void PlusNumbers(int a, int b);
        }

        public class MyMath : IPlus
        {
            public void PlusNumbers(int a, int b)
            {
                Console.WriteLine("Полученное число: {0}", a+b);
            }



        }


    }

    public interface ILogger
    {
        void Event(string message);
        void Error(string message);
    }


    public class Logger : ILogger
    {
        public void Error(string message)
        {
            Console.WriteLine(message);
        }

        public void Event(string message)
        {
            Console.WriteLine(message);
        }
    }

    public interface IWorker
    {
        void Work();
    }

}
