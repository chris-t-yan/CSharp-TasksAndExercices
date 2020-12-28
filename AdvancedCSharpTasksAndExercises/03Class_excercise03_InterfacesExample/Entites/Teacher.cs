using _03Class_excercise03_InterfacesExample.Entites.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _03Class_excercise03_InterfacesExample.Entites
{
    public class Teacher : User, ITeacher
    {
        public List<string> Subjects { get; set; } = new List<string>();
        public void PrintSubject()
        {
            foreach (var subject in Subjects)
            {
                Console.WriteLine(subject);
            }
        }
    }
}
