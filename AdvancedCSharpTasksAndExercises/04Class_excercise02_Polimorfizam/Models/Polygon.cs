using System;
using System.Collections.Generic;
using System.Text;

namespace _04Class_excercise02_Polimorfizam.Models
{
    public class Polygon : Form
    {
        public int NumberOfPoints { get; set; }
        public override void Draw()
        {
            Console.WriteLine("A polygon is drawn");
        }

        public virtual string GetTypeOfPolygon()
        {
            return "Generic polygon";
        }
    }
}
