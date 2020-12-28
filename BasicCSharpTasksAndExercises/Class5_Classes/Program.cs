using System;

namespace Class5_Classes
{   
    public class Participant
    {
        #region Class Deffinition
        //Class = Properties + Methods
        //Class = DATA + BEHAVIOR
        #endregion
            //PUBLIC, PRIVATE, INTERNAL, PROTECTED

        //Properties = DATA
        //Template   
        public string FirstName;
        public string LastName;

        public DateTime DateOfBirth;
        
        private int Age;

        //Template
        //Methods = BEHAVIOUR
        public  void Greetings()
        {   
            Console.WriteLine($"Hello, I'm {FirstName} {LastName}");

            HowOld(DateTime.Today);
            Console.WriteLine($"Also, I'm {Age} years old.");
        }
        private void HowOld(DateTime today)
        {
            if (today.Month < DateOfBirth.Month)
            {
                Age = today.Year - DateOfBirth.Year - 1;
            }
            
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            int number = 10;

            var participant1 = new Participant();
            participant1.FirstName = "Miodrag";
            participant1.LastName = "Cekikj";
            participant1.DateOfBirth = new DateTime(1989, 5, 15);

            //participant1.HowOld(DateTime.Today);
            
            participant1.Greetings();


            var participant2 = new Participant();
            participant2.FirstName = "Goce";
            participant2.LastName = "Kabov";
            participant2.DateOfBirth = new DateTime(1992, 5, 15);
            participant2.Greetings();

            Console.ReadLine();
        }
    }
}
