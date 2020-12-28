using System;

namespace Class14_exercise2_ExceptionsMultipleCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            //GLOBAL EXCEPTION HANDLING MECHANISM
            try
            {
                //ALL CODE HERE
            }
            catch (Exception)
            {
                Console.WriteLine(); ;
            }


            Console.WriteLine("Please be nice and enter value for BYTE: ");
            byte number = 0;
            
            // 1. Catch exception if occured because of the code logic
            // 2. Re throw/ Throw the exception!
            try
            {
                //number = byte.Parse(Console.ReadLine());

                //if (Ilija not exist)
                {
                    throw new OverflowException("No such contact");
                }
            }
            //catch (OverflowException ex)
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine("Overflow exception occured!");
            //    Console.WriteLine("You have entered negative or number bigger than 255");
            //    Console.ResetColor();
            //}
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
                //code for email here => always if exception happened!!!
            }
            //catch (FormatException ex)
            //{
            //    Console.WriteLine("Format exception occured!");
            //    Console.WriteLine("You have entered text instead of byte number");
            //    Console.ForegroundColor = ConsoleColor.Green;
            //    Console.ResetColor();
            //}



            //catch (ArgumentNullException ex)
            //{
            //    Console.ForegroundColor = ConsoleColor.Yellow;
            //    Console.WriteLine("ArgumentNullException occured");
            //    Console.WriteLine("You are trying to parse NULL");
            //    Console.ResetColor();
            //}
            Console.WriteLine("The value is: " + number);


            Console.ReadLine();
        }
    }
}
