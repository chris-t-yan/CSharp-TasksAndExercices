using System;
using System.Collections.Generic;
using System.Text;

namespace _03Class_excercise01_AbstractClasses.Entities
{
    public class Trainer : User
    {
        public Trainer(int age=18)
        {
            Console.WriteLine("Trainer is born");
            Age = age;
        }
        public string CurrentSubject { get; set; }

        public override void SayHi()
        {
            Console.WriteLine($"Hi my name is {Name} and I am trainer"); ;
            ;
        }
    }
}
