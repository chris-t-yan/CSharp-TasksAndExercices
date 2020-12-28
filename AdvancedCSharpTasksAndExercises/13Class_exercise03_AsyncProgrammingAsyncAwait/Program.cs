using System;
using System.Threading;
using System.Threading.Tasks;

namespace _13Class_exercise03_AsyncProgrammingAsyncAwait
{
    class Program
    {
        static  void Main(string[] args)
        {
            PrintMessageTask();
            Console.ReadLine();
        }

        public static async void PrintMessageTask()
        {
            var result = await SendMessageAsync("Hola1");
            var result1 = await SendMessageAsync("Hola2");

            Console.WriteLine(result);
            Console.WriteLine(result1);
        }

       

        public static async Task<string> SendMessageAsync(string message) 
        {
            Console.WriteLine("Sending message");

            return await Task.Run(() => 
            {
                Thread.Sleep(2000);
                return $"Message is {message}";
            });
            
        }

    }
}
