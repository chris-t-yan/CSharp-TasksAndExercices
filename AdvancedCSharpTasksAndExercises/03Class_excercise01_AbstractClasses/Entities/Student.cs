using System;
using System.Collections.Generic;
using System.Text;

namespace _03Class_excercise01_AbstractClasses.Entities
{
    public class Student : User
    {
        public int Group { get; set; }

        public override void SayHi()
        {
            Console.WriteLine($"Hi my name is {Name} and I am student"); ;
        }
    }
}
