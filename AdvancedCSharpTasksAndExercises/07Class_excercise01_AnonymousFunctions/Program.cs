using System;
using System.Collections.Generic;

namespace _06Class_excercise01_AnonymousFunctions
{
    class Program
    {

        public static List<string> Names { get; set; } = new List<string> { "Bob"};

        static  void Main(string[] args)
        {
            Func<int, int, float> Operation;

            Operation = Sum;
            CalculateAndPrint(Operation);

            Operation = Devide;
            CalculateAndPrint(Operation);
        }

      

        public static void CalculateAndPrint(Func<int, int, float> operation)
        {
            var result = operation(4, 2);
            Console.WriteLine(result);
        }
        public static float Sum (int x, int y)
        {
            return x + y;
        }

        public static float Devide(int x, int y)
        {
            return x / y;
        }


    }
}
