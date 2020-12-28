using System;

namespace Class15_FinalTask_Market
{
    class Program
    {
        static void Main(string[] args)
        {

            var product = new Product();
            product.Price = 100;
            Console.WriteLine($"The price of the product is {product.Price}");



            Console.ReadLine();
        }
    }
}
