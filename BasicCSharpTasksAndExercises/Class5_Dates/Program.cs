using System;

namespace Class5_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating DateTime - empty/initial

            DateTime date = new DateTime();
            Console.WriteLine(date);

            //creating a costum DateTime - my birthday
            var birthday = new DateTime(1992, 4, 26, 5, 30, 12);
            Console.WriteLine(birthday);

            //NO COMPILE TIME ERROR!
            //Broken application !!!
            //var custumDate = new DateTime(-1989, 5, 15);

            //DateTime cobinations and from STRING conversion
            string date1 = "15/05/89";
            string date2 = "15.5.1989";
            string date3 = "15/5/1989 03:05:12";
            string date4 = "26-03-2020";
            string date5 = "mar.26.2020";
            

            Console.WriteLine("DATE TIME CONVERSION:");
            DateTime conversionDate2 = DateTime.Parse(date4);
            Console.WriteLine(conversionDate2);

            //today date
            var today = DateTime.Now;
            Console.WriteLine(today);

            int day = today.Day;
            int month = today.Month;
            int year = today.Year;

            Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");

            Console.WriteLine("Tomorrow is " + today.AddDays(1));
            Console.WriteLine("Yesterday was " + today.AddDays(-1).AddHours(1));

            //Formatting dates
            string dateFormat = today.ToString("MM/dd/yyyy");
            Console.WriteLine(dateFormat);

            string dateFormatAnother = today.ToString("dddd, dd MMMM yyyy");
            Console.WriteLine(dateFormatAnother);

            Console.ReadLine();
        }
    }
}
