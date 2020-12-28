using _03Class_excercise03_InterfacesExample.Entites.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _03Class_excercise03_InterfacesExample.Entites
{
    public abstract class User : IUser
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public void PrintUser()
        {
            Console.WriteLine($"ID: {Id}, UserName: {UserName}, Name {Name}");
        }
    }
}
