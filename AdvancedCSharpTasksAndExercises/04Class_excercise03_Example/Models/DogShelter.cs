using System;
using System.Collections.Generic;
using System.Text;

namespace _04Class_excercise03_Example.Models
{
    public static class DogShelter
    {
        public static List<Dog> Dogs;

        public static void PrintAll()
        {
            foreach (var dog in Dogs)
            {
                Console.WriteLine(dog.Name);
            }
        }
    }
}
