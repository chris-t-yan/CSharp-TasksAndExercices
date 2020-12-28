using System;
using System.Collections.Generic;

namespace Class16_Recap_StaticKeyword
{
    class Program
    {
        //public static class StaticClass
        //{
        //    public static int MyProperty { get; set; }
        //}

        public class Employee
        {
            static Employee()
            {
                Console.WriteLine("New instance is created from static constructor");
                Friends = new List<string>();
            }
            public Employee()
            {
                Console.WriteLine("new instance is created from default constructor");
                NumberOfEmployees++;
            }
            public string Name { get; set; }
            public static int NumberOfEmployees { get; set; }
            public static List<string> Friends { get; set; }
            public static void GetGriends() 
            {
                Console.WriteLine(Friends);
            }
        }
        static void Main(string[] args)
        {
            //var staticClass = new StaticClass();
            var firstEmployee = new Employee() { Name = "Miodrag" };
            //var secondEmployee = new Employee() { Name = "Buco" };
            //var thirdEmployee = new Employee() { Name = "Viktor" };
            
            Console.WriteLine(Employee.NumberOfEmployees);
            Console.WriteLine(Employee.NumberOfEmployees);



            Console.ReadLine();
        }
    }
}
