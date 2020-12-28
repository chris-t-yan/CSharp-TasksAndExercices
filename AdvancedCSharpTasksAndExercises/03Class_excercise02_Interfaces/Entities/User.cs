using _03Class_excercise02_Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _03Class_excercise02_Interfaces.Entities
{
    public abstract class User : IUser
    {

        public string Name { get; set; }
        public int Age { get; set; }
        public int GetAge()
        {
            return Age;
        }

        public void SayHi()
        {
            Console.WriteLine($"Hy my name is {Name}");
        }

        public void SetName(string name)
        {
            Name = name;
        }

        public void SaySomethingElse()
        {
            Console.WriteLine("Something else");
        }
    }
}
