using _06Class_excercise03_LINQ.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace _06Class_excercise03_LINQ.Db
{
    public static class TestDb
    {
        public static List<Student> Students = new List<Student>()
        {
           new Student() { Id = 1, FirstName = "Bob", LastName = "Bobsky"},
           new Student() { Id = 2, FirstName = "Jill", LastName = "Wayne"},
           //new Student() { Id = 3, FirstName = "Greg", LastName = "Gregsky"},
           //new Student() { Id = 4, FirstName = "Anne", LastName = "BoWillsonbsky"},
           //new Student() { Id = 5, FirstName = "Bill", LastName = "Zu"}
        };

        public static List<Subject> Subjects = new List<Subject>()
        {
            new Subject(){Id = 1, Name = "C# Basic", NumberOfClasses = 15, Trainer = "Liana", isMandatory = true},
            new Subject(){Id = 2, Name = "C# Advanced", NumberOfClasses = 15, Trainer = "Wurtz", isMandatory = true},
            new Subject(){Id = 3, Name = "Network Basics", NumberOfClasses = 15, Trainer = "John", isMandatory = false},
            new Subject(){Id = 4, Name = "Photoshop", NumberOfClasses = 15, Trainer = "Jane", isMandatory = true},
        };

        public static void InitDb()
        {
            Students[0].Subjects = new List<Subject>() { Subjects[0], Subjects[1] };
            Students[1].Subjects = new List<Subject>() { Subjects[3], Subjects[2] };

        }
    }
}
