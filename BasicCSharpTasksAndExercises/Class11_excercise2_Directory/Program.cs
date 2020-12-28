using Class11_excercise2_Directory.Models;
using System;

namespace Class11_excercise2_Directory
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneBook phoneBook = new PhoneBook();
            phoneBook.Directory
                .Add(new User() { Name = "Miodrag", Adress = "Aerodrom" },
                "077-655-555");
            phoneBook.Directory
                .Add(new User() { Name = "Goce", Adress = "Centar" },
                "078-665-111");
            phoneBook.Directory
                .Add(new User() { Name = "John", Adress = "Chicago" },
                "070-100-007");

            var user = new User() { Name = "Miodrag", Adress = "Aerodrom" };
            Console.WriteLine(phoneBook.SearchContactNumber(user));
            Console.WriteLine("-----------------------------------");

            phoneBook.PrintContacts();

            Console.ReadLine();
        }
    }
}
