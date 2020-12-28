using System;

namespace Farewall
{
    class Program
    {
        static void Main(string[] args)
        {
            float x, y, a;
            for (y = 1.5f; y > -1.5f; y -= 0.1f)
            {
                for (x = -1.5f; x < 1.5f; x += 0.05f)
                {
                    a = x * x + y * y - 1;
                    Console.Write(a * a * a - x * x * y * y * y <= 0.0f ? "*" : " "); ;
                }
                Console.WriteLine();

            }
            Console.ReadLine();
        }
    }
}
