using System;
using System.Collections.Generic;
using System.Text;

namespace _04Class_excercise02_Polimorfizam.Models
{
    public class Square : Polygon
    {
        public override string GetTypeOfPolygon() 
        {
            return "Square - polyfon with 4 points";
        }

        public override void Draw()
        {
            Console.WriteLine("A swuare is drawn"); ;
        }
    }
}
