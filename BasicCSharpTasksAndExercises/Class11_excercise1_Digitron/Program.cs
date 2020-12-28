using System;
using System.Collections.Generic;
using Class11_excercise1_Calculator.Models;

namespace Class11_excercise1_Digitron
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 10, 20, 40, 30, 5 };

            int maxNumber = Calc.Max(numbers);
            Console.WriteLine($"The biggest number is: { maxNumber} " );
            Console.WriteLine("--------------------------------------");
            Console.WriteLine($"The average of the array is: {Calc.Avg(numbers)}");
            Console.ReadLine();
        }
    }
}
