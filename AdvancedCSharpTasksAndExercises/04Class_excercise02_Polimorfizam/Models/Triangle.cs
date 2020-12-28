using System;
using System.Collections.Generic;
using System.Text;

namespace _04Class_excercise02_Polimorfizam.Models
{
    public class Triangle : Polygon
    {
        public override string GetTypeOfPolygon() 
        {
            return "Triangle - polygon with 3 points";
        }

        public override void Draw()
        {
            Console.WriteLine("A triangle is drawn"); ;
        }
    }
}
