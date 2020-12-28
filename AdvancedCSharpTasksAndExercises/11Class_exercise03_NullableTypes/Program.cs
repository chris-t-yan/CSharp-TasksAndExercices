using System;

namespace _11Class_exercise03_NullableTypes
{
    public class Person
    {
        public int ID { get; set; }
        public int? Score { get; set; }
        public bool IsEmployed { get; set; }
        public bool? HasPet { get; set; }
        public string Name { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Console.WriteLine(person.ID);
            Console.WriteLine(person.Score);
            person.Score = null;
            person.Name = null;
            //person.IsEmployed = null;
            //person.ID = null;
            person = null;
        }
    }
}
