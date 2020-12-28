using System;
using System.Collections.Generic;
using System.Linq;


namespace _06Class_excercise02_AnonymousFunctions
{
    class Program
    {
        public static List<string> Names { get; set; } = new List<string>
        {
            "Bob",
            "Jill",
            "Wayne",
            "Greg",
            "John",
            "Anne"
        };

        public static List<string> EmptyList { get; set; } = new List<string>();

        static void Main(string[] args)
        {
            Func<bool> isNamesListEmpty = () => Names.Count == 0;
            Func<List<string>, bool> isListEmpty = (x) => x.Count == 0;

            Action<string> PrintAction = text => Console.WriteLine(text);

            PrintAction($"Is list empty: {isListEmpty(Names) }");

            Func<string, bool> isBobFound = (name) => name == "Anne";

            string findBob = Names.FirstOrDefault(isBobFound);

            var result = Names.FindOrDefoult(name => name.Contains("ll"));
            Console.WriteLine($"{result}");

        }

        
    }
}
