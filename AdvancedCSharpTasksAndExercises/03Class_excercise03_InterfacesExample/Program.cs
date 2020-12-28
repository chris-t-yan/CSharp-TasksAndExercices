using _03Class_excercise03_InterfacesExample.Entites;
using System;
using System.Collections.Generic;

namespace _03Class_excercise03_InterfacesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student()
            {
                Id = 1,
                Name = "John",
                Password = "123",
                UserName = "John Doe",
                Grades = new List<int>() { 5, 5, 5, 5, 5}
            };

            Teacher teacher1 = new Teacher() 
            {
                Id = 2,
                Name = "Ivan",
                Password = "Ivan123",
                UserName = "Ivanco",
                Subjects = { "CSS", "HTML", "JavaScript", "C#"}
            };

            student1.PrintUser();
            Console.WriteLine("---------------------------------------");

            teacher1.PrintUser();
            Console.WriteLine("---------------------------------------");

            student1.ShowGrades();
            Console.WriteLine("---------------------------------------");

            teacher1.PrintSubject();


        }
    }
}
