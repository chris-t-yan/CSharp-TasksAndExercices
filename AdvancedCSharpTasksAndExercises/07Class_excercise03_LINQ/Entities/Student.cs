using System;
using System.Collections.Generic;
using System.Text;

namespace _06Class_excercise03_LINQ.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public List<Subject> Subjects { get; set; }
        
    }
}
