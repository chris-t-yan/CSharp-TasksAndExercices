using _03Class_excercise02_Interfaces.Entities;
using System;

namespace _03Class_excercise02_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Student user = new Student() { Name = "Ivan"};
            user.SayHi();
        }
    }
}
