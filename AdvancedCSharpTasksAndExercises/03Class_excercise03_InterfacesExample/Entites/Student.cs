using _03Class_excercise03_InterfacesExample.Entites.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _03Class_excercise03_InterfacesExample.Entites
{
    public class Student : User, IStudent
    {
        public List<int> Grades { get; set; } = new List<int>();

        public void ShowGrades()
        {
            foreach (var grade in Grades)
            {
                Console.WriteLine(grade);
            }
        }
    }
}
