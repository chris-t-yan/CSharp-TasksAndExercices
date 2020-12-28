using System;
using System.Collections.Generic;
using System.Text;

namespace _04Class_excercise02_Polimorfizam.Models
{
   public abstract class Form
    {
        public float Width { get; set; }
        public float Height { get; set; }
        public abstract void Draw();
    }
}
