using System;

namespace Class6_Enums
{
    //C# enumeration (ENUMS)
    public enum Days
    {
        Monday = 1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine((int)Days.Monday);

            Console.ReadLine();
        }
    }
}
