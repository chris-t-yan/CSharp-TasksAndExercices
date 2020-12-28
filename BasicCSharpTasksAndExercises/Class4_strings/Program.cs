using System;

namespace Class4_strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("we are starting with strings");

            string academy = "seavus educational and development center";
            string academyAcronym = "SEDC";

            //string academyTitle = academy + " - " + academyAcronym;

            //Console.WriteLine("{0} - {1}", academy, academyAcronym);

            string academyTitle = string.Format("{0} - {1}", academy, academyAcronym);
            Console.WriteLine(academyTitle);

            float price = 150.28f;
            string currency = string.Format("{0:C}", price);
            Console.WriteLine(currency);

            float part = 0.5f;
            string percent = string.Format("{0:P}", part);
            Console.WriteLine(percent);

            var mobileNumber = 38970111222;
            string mobileNumberFancy = string.Format("{0:(###) ## ###-###}", mobileNumber);
            Console.WriteLine(mobileNumberFancy);

            string group = "G1";
            string behavior = "Rocks!";

            string what = $"{group} is amaizing! the group {behavior}";
            Console.WriteLine(what);

            string path = @"C:\Users\hrist\Desktop\SEDC 2019-2020";
            Console.WriteLine(path);

            // /n - new line
            // /t - tab
            string withQuatations = "online \t training is GREAT";
            Console.WriteLine(withQuatations);

            //Console.WriteLine(academyTitle);

            Console.ReadLine();
        }
    }
}
