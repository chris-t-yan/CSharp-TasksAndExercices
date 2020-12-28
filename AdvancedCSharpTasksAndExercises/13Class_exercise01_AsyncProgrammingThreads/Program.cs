using System;
using System.Threading;

namespace _13Class_exercise01_AsyncProgrammingThreads
{
    class Program
    {
        static void Main(string[] args)
        {
            //PrintMessages();
            PrintMessagesWithThreads();
        }

        public static void PrintMessages()
        {
            Console.WriteLine("Get ready");
            Thread.Sleep(2000);
            Console.WriteLine("First messgae");
            Thread.Sleep(2000);
            Console.WriteLine("Second message");
            Console.ReadLine();
        }
        

        public static void PrintMessagesWithThreads()
        {
            Console.WriteLine("Get ready");
            Thread threadOne = new Thread(()=> {
                Thread.Sleep(2000);
                Console.WriteLine("First messgae");
            });

            new Thread(() => {
                Thread.Sleep(2000);
                Console.WriteLine("Second message");
            }).Start();

            Thread.Sleep(1000);
            threadOne.Start();
            Console.ReadLine();
        }
    }
}
