using System;
using System.Collections.Generic;
using System.Text;

namespace _06Class_excercise03_LINQ.Entities
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Trainer { get; set; }
        public int NumberOfClasses { get; set; }
        public bool isMandatory { get; set; }
    }
}
