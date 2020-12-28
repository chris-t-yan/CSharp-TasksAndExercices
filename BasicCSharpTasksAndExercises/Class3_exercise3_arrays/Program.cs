using System;

namespace Class3_exercise3_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cars = new string[] { "Volvo", "BMW", "Ford", "Mazda", "Mercedes" };
            double[] decimalNumbers = new double[] { 10.4, 12.4, 12.8, 9.5, 4.5};
            char[] charValues = new char[] {'a', '.', '?', '|', ';' } ;
            bool[] boolValues = new bool[] { true, false, true, false, true };

            

            int[] userInput = new int[5];
            int numberOfElement = 1;
            for (int i = 0; i < userInput.Length; i++)
            {
                Console.WriteLine("Enter number " + numberOfElement + ":");
                userInput[i] = int.Parse(Console.ReadLine());
                numberOfElement++;
            }

            int sum = 0;
            foreach (var num in userInput)
            {
                sum += num;
            }
            Console.WriteLine("The result of the elements in the array is " + sum);


        }
    }
}
