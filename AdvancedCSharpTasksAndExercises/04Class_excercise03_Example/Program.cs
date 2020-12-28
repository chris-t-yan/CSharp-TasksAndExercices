using _04Class_excercise03_Example.Models;
using System;

namespace _04Class_excercise03_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            var kim = new Dog
            {
                Id = 1,
                Name = "Kim",
                Color = "Ochre"
            };

            var dzeki = new Dog
            {
                Id = 2,
                Name = "Dzeki",
                Color = "Brown"
            };

            var sharko = new Dog
            {
                Id = 3,
                Name = "",
                Color = "Mixed"
            };

            bool isKimValid = Dog.Validate(kim);
            bool isDzekiValid = Dog.Validate(dzeki);
            bool isSharkoValid = Dog.Validate(sharko);

            if (isDzekiValid) 
            {
                DogShelter.Dogs.Add(dzeki);
            }
            if (isKimValid)
            {
                DogShelter.Dogs.Add(kim);
            }
            if (isSharkoValid)
            {
                DogShelter.Dogs.Add(sharko);
            }
        }
    }
}
