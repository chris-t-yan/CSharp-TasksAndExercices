using System;
using System.Collections.Generic;
using System.Text;

namespace _14Class_exercise03_PracticesAndPrinciples.Naming
{
    class PropertiesAndFields
    {
        private string _field;
        public string Field { get; set; }
        public bool isDeleted { get; set; }
        public bool CanLogin { get; set; }
        public bool HasCheckedIn { get; set; }
    }
}
