using System;
using System.Collections.Generic;
using System.Text;

namespace _04Class_excercise03_Example.Models
{
    public class Dog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public void Bark()
        {
            Console.WriteLine("Bark Bark");
        }

        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Color: {Color}";
        }

        public static bool Validate(Dog dog)
        {
            if (dog.Id < 0 
                        && string.IsNullOrWhiteSpace(dog.Name) 
                        && string.IsNullOrWhiteSpace(dog.Color))
            {
                return false;
            }
            else 
            {
                return true;
            }
        }
    }
}
