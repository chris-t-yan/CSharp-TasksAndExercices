using _04Class_excercise02_Polimorfizam.Models;
using System;

namespace _04Class_excercise02_Polimorfizam
{
    class Program
    {
        static void Main(string[] args)
        {
            var polygon = new Polygon();
            var square = new Square();
            var triangle = new Triangle();

            polygon.Draw();
            square.Draw();
            triangle.Draw();

            Console.WriteLine($"polygon: {polygon.GetTypeOfPolygon()}");
            Console.WriteLine($"square: {square.GetTypeOfPolygon()}");
            Console.WriteLine($"triangle: {triangle.GetTypeOfPolygon()}");
        }
    }
}
