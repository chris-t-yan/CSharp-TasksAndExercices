using System;

namespace Class3_exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert number");
            var userInput = Console.ReadLine();

            int number;
            bool conversion = int.TryParse(userInput, out number);

            if (conversion)
            {
                for (int i=1; i<=number; i++)
                {
                    if (i % 3 == 0 || i % 7 == 0)
                        continue;

                    else if (i >= 100) { 
                        Console.WriteLine("The limit is reached");
                        break;
                    }
                    Console.WriteLine(i);
                }
                Console.ReadLine();

            } else
                Console.WriteLine("Enter valid number");
        }
    }
}
