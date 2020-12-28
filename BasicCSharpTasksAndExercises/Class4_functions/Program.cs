using System;

namespace Class4_classCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello world");
            #region Part 1
            //    int firstNumber = 10;
            //    int secondNumber = 20;
            //    int thirdNumber = 100;

            //    var numbers = new int[] { 10, 20, 30, 40, 50, 80 };
            //    int sumOfAll = Sum(numbers);
            //    Console.WriteLine(sumOfAll);

            //    int result = Sum(firstNumber, secondNumber);
            //    int anotherResult = Sum(firstNumber, secondNumber, thirdNumber);

            //    Console.WriteLine("The sum of the numbers is " + result);

            //    Console.ReadLine();
            //}

            #endregion
            #region Part 2
            string group = "G1";
            Greetings(group);
            #endregion

            int num = 50;
            var result = Increment(num);
            Console.WriteLine(result);

        }
        public static int Sum(int first, int second)
        {
            int result = first + second;

            return result;
        }

        public static int Sum(int first, int second, int third)
        {
            return first + second + third;
        }

        public static int Sum(int first, bool second)
        {
            return 10;
        }

        public static int Sum(int[] numbers)
        {
            int sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }
            return sum;
        }
        public static void Greetings(string group)
        {
            Console.WriteLine("{0} is enjoying the online training", group);
        }

        public static bool TrueOrFalse()
        {
            return true;
        }

        public static int Increment (int number)
        {
            number += 100;
            return number;
        }
    }

}
