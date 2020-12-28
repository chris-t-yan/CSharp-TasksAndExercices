using System;

namespace Class2_exercise2_dataConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vnesi broj");
            var userInput = Console.ReadLine();

            bool isCoversionSuccess;
            int number;
            bool result = int.TryParse(userInput, out number);

            //int convertedNumber = int.Parse(userInput);

            Console.WriteLine(number);
            Console.ReadLine();

        }
    }
}
