using Lottary.Entities;
using Lottary.Enums;
using Lottary.Helpers;
using System;

namespace Lottary
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create structure
            //Create models
            User user = new User()
            {
                FullName = "Igor Dzambazov"
            };

            user.SetAge(55);
            Ticket ticket = new Ticket()
            {
                Combination = new int[] { 26, 2, 16, 5, 31, 19, 12 },
                User = user
            };

            FirstSession firstSession = new FirstSession()
            {
                Tickets = new Ticket[] { ticket }
            };
            firstSession.StartSession();
            foreach (var number in ticket.Combination)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine("---------------------------------------------------");
            foreach (var number in firstSession.WinningCombination)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine("----------------------------------------------------");
            var matches = LottaryHelpers.CheckTicket(firstSession.WinningCombination, ticket.Combination);
            switch (matches)
            {
                case (int)Prize.TV:
                    Console.WriteLine(Prize.TV);
                    break;
                case (int)Prize.Vacation:
                    Console.WriteLine(Prize.Vacation);
                    break;
                case (int)Prize.Motorbike:
                    Console.WriteLine(Prize.Motorbike);
                    break;
                case (int)Prize.Car:
                    Console.WriteLine(Prize.Car);
                    break;
                default:
                    Console.WriteLine("The ticket is without win");
                    break;
            }

            //firstSession.GetRandomTicket();


            Console.ReadLine();
        }
    }
}
