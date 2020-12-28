using System;
using System.Dynamic;
using System.IO;

namespace _11Class_exercise01_StackHeap_ManagingResources
{
    class Program
    {
        class Person
        {
            public int ID { get; set; }
        }
        static void Main(string[] args)
        {
            //int number = 19;
            //string text = "some text";
            //bool isTrue = true;
            Person person = new Person() { ID = 1 };
            Person person1 = new Person() { ID = 1 };
            Console.WriteLine(person == person1);
            person.ID = 2;
            person.ID = 5;

            CreatePerson();

            var path = "asdasdasd";
            var sr = new StreamWriter(path);
            sr.Close();
            sr.Dispose();
            using (sr = new StreamWriter(path))
            {
                //do anything
            }

            //Stack
                //number = 19
                //text = some text
                //isTrue = true
                //person = 223423423423
                //person1 = 12321321321321

            //Heap
                //Person -- {ID = 2 }
                //Person1 -- {ID = 1}
        }
        public static void CreatePerson()
        {
            var person = new Person();
            person.ID = 1;
        }
    }
}
