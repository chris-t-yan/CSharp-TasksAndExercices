using System;

namespace Class3_exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert number for 1 to 3");
            var userInput = Console.ReadLine();

            int number;
            bool conversion = int.TryParse(userInput, out number);

            if (conversion)
            {
                if (number == 1)
                {
                    Console.WriteLine("You got a new car");
                }
                else if (number == 2)
                {
                    Console.WriteLine("You got a new plane");
                }
                else if (number == 3)
                {
                    Console.WriteLine("you got new bike");
                }
                else
                    Console.WriteLine("Invalid input, please input number from 1 to 3");
            } else
                Console.WriteLine("this is not a number");

            //if (conversion)
            //{
            //    switch (number)
            //    {
            //        case 1:
            //            Console.WriteLine("You got a new car");
            //            break;
            //        case 2:
            //            Console.WriteLine("You got a new plane");
            //            break;
            //        case 3:
            //            Console.WriteLine("you got new bike");
            //            break;
            //        default:
            //            Console.WriteLine("Invalid input, please input number for 1 to 3");
            //            break;
            //    }
            //} else
            //    Console.WriteLine("this is not a number");


        }
    }
}
