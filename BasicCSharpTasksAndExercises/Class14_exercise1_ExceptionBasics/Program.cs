using System;

namespace Class14_exercise1_ExceptionBasics
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please insert a number for division: ");


            int result = 0;
            //TRY => always the code that can generates ERROR!
            try
            {
                int number = int.Parse(Console.ReadLine());
                result = 10 / number;
            }
            //CATCH => Always  the code for HANDLING the ERROR :/
            catch (Exception )
            {

                Console.WriteLine("Something wrong happened..."); 
            }
            //FINALLY => always code that will be EXECUTED :)
            finally
            {
                Console.WriteLine("I'm here FINNALY :)))))");
            }

            
            
            Console.WriteLine("The division of 10 with number is: " + result );
            

            
            Console.WriteLine("The application continues...:");
            //more code and implementation
            
            Console.ReadLine();
        }
    }
}
