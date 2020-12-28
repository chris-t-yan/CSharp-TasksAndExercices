using System;
using System.Collections.Generic;

namespace Class16_Recap_Iheritance
{
    class Program
    {
        class FirstClass
        {
            public string Name { get; set; } = "Goce";
        }
        class SecondClass : FirstClass
        {
           
        }
        class CustomList<T> where T : class
        {
            //biloSto
        }
        static void Main(string[] args)
        {
            var secondClass = new SecondClass();
            Console.WriteLine(secondClass.Name);

            var list = new List<int>();
            var listNew = new CustomList<SecondClass>();

            
            
            Console.ReadLine();
        }
    }
}
