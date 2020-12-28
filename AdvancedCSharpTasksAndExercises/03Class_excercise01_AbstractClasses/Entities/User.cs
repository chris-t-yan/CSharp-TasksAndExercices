using System;
using System.Collections.Generic;
using System.Text;

namespace _03Class_excercise01_AbstractClasses.Entities
{
    public abstract class User
    {
        public User()
        {
            Console.WriteLine("User is born");
            
        }
        public string Name { get; set; }
        public int Age { get; set; }

        public abstract void SayHi();
        
    }
}
