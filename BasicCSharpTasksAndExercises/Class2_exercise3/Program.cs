using System;

namespace Class2_exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vnesi broj");
            var userInput = Console.ReadLine();

            int number;
            bool conversion = int.TryParse(userInput, out number);

            if (conversion)
            {
                var result = number % 10;

                Console.WriteLine(result);
            }
            else Console.WriteLine("Invalid input, please input valid number");

        }

    }   
}
