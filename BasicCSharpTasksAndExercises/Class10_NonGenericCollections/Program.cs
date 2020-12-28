using System;
using System.Collections;

namespace Class10_NonGenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arrays
            var numbers = new int[3];
            var otherNumers = new int[2] { 10, 20 };
            var anotherNumbers = new int[] { 10, 20, 30 };

            //System.Collections Namespace
            //ArrayList - collection of OBJECTS - .NET Framework 1.0 (extension on Arrays)
            ArrayList somethingOfSomething = new ArrayList();
            somethingOfSomething.Add(100);
            somethingOfSomething.Add("Seavus Educational and Development Center");
            somethingOfSomething.Add(true);

            foreach (var item in somethingOfSomething)
            {
                Console.WriteLine(item);
            }

            //The need EXPLICIT CASTING
            var something = (string)somethingOfSomething[1];


            //Cannot SORT elements with different data types
            //somethingOfSomething.Sort();

            Console.WriteLine($"The capacity of the Turlitava is: {somethingOfSomething.Capacity}");
            Console.WriteLine(something);

            Console.ReadLine();
        }
    }
}
