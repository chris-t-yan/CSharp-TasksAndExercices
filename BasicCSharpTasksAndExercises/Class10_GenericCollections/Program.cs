using System;
using System.Collections.Generic;

namespace Class10_GenericCollections
{
    public class Car
    {
        public string Model;
    }
    class Program
    {
        static void Main(string[] args)
        {
            //List
            List<string> sedcGroups = new List<string>() { "G1", "G2", "G3", "G4", "G5", "G6", "G7", "G8"};
            sedcGroups.AddRange(new List<string>() { "G9", "G10" });

            sedcGroups.Add("G11");

            foreach (var item in sedcGroups)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"The number of elements is: {sedcGroups.Count}");

            var automobileShop = new List<Car>();

            var car1 = new Car();
            car1.Model = "BMW";

            automobileShop.Add(car1);

            //sedcGroups.Add("G1");
            //sedcGroups.Add("G2");


            //Dictinary <Key, Value>
            Dictionary<string, int> examPoints = new Dictionary<string, int>() { {"Miodrag", 50 }, { "Goce", 100} };
            //examPoints.Add("Miodrag", 50);
            //examPoints.Add("Goce", 100);

            examPoints.Remove("Miodrag");

            foreach (var item in examPoints)
            {
                Console.WriteLine($"The first student is: {item.Key}, points: {item.Value}");
            }

            var cars = new Dictionary<string, Car>();
            cars.Add("SK1111AA", car1);


            //Queue - FIFO (First In First Out) ex Market
            var bankQueue = new Queue<string>();
            bankQueue.Enqueue("Buco");
            bankQueue.Enqueue("Ilija");
            bankQueue.Enqueue("Marija");

            var served = bankQueue.Dequeue();

            var next = bankQueue.Peek();

            Console.ForegroundColor = ConsoleColor.Red;

            foreach (var item in bankQueue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Served is: " + served);

            //Stack - LIFO (Last In First Out) ex Sport Bag 
            Console.ForegroundColor = ConsoleColor.Yellow;

            var sportBag = new Stack<string>();
            sportBag.Push("Trainers");
            sportBag.Push("T-shirt");
            sportBag.Push("Towel");

            var equipment = sportBag.Peek();
            Console.WriteLine("Next part is: " + equipment);

            //sportBag.Pop();
            
            foreach (var item in sportBag)
            {
                Console.WriteLine(item);
            }


            Console.ReadLine();
        }
    }
}
