using System;

namespace _08Class_excercise01_Delegates
{
    class Program
    {
        //Declaring delagates
        //This is the signature of any method that we want this delegate to point to
        public delegate void SayDelegate(string something);
        public delegate int NumbersDelegate(int num1, int num2);
        static void Main(string[] args)
        {
            SayDelegate del = new SayDelegate(SayHello); //The SayDelegate points to SayHello
            SayDelegate bye = new SayDelegate(SayBye);// The SayDelegate points to SayBye
            SayDelegate wow = new SayDelegate(name => Console.WriteLine($"wow {name}"));


            //using the delegate
            //del("Bob");
            //bye("Jill");
            //wow("John Doe");

            //SayWhatever("Bob", SayBye);

            NumberMaster(2, 5, (x, y) => x + y);
            NumberMaster(2, 5, (x, y) => x - y);
            NumberMaster(2, 5, (x, y) => 0);

        }

        public static void SayHello(string person)
        {
            Console.WriteLine($"Hello {person}");
        }

        public static void SayBye (string person)
        {
            Console.WriteLine($"Bye {person}!");
        }

        public static void SayWhatever(string whatever, SayDelegate sayDel)
        {
            Console.WriteLine("Chatbot says: ");
            sayDel(whatever);
        }

        public static void NumberMaster(int num1, int num2, NumbersDelegate numberDelegate)
        {
            Console.WriteLine($"The result is: {numberDelegate(num1, num2)}");
        }
    }
}
