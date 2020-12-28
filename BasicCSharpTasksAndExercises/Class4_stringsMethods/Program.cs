using System;

namespace Class4_stringsMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Length() dolzina
            //ToLower() gi pravi site mali karakteri
            //ToUpper() gi pravi site golemi karakteri

            string groupFeedback = "c# is great progrtamming language";
            Console.WriteLine($@"The length of {groupFeedback} ""STRING"" is {groupFeedback.Length} characters");

            int numberOfCharachtersInTheString = groupFeedback.Length;

            Console.WriteLine("All letters smaller: {0}", groupFeedback.ToLower());
            Console.WriteLine("All letters capital: " + groupFeedback.ToUpper());


            //Trim()
            //TrimStart()
            //TrimEnd()
            //cut empty spaces in the begining or at the end of the string

            string gitUsername = "     miodragc     ";
            Console.WriteLine("Git username: " + gitUsername.Length);//25

            string gitUsernameTrimmed = gitUsername.Trim();
            Console.WriteLine($"Git username length with Trim() is: {gitUsernameTrimmed.Length}");//8

            string gitUsernameTrimmedStart = gitUsername.TrimStart();
            string gitUsernameTrimmedEnd = gitUsername.TrimEnd();

            Console.WriteLine("Please insert your username and password: ");
            string username = "  miodragc  ";
            string usernameTrim = username.Trim();

            //StartWith()
            //EndsWith()
            //IndexOf()

            string academySubjects = "HTML, CSS, Java Script, C#";
            string html = "HTML  ";

            bool htmlIsFirstSubject = academySubjects.StartsWith("HTML");
            bool htmlIsFirstSubjectWithSpace = academySubjects.StartsWith(html.Trim());
            bool cSharpIsCurrentSubject = academySubjects.EndsWith("C#");
            var indexOfJavaScript = academySubjects.IndexOf("Java Script");
            Console.WriteLine($"HTML is first subject: {htmlIsFirstSubject}, C# is current subject:  {cSharpIsCurrentSubject}, Java Script with index {indexOfJavaScript}");

            //Substring()
            //Split() - FANTASTIC
            //ToCharArray() - Like*Like

            //get all subjects from SEDC except HTML
            string allSubjectsExceptHTML = academySubjects.Substring(6);
            Console.WriteLine("All subjects from SEDC without the HTML are: " + allSubjectsExceptHTML);

            string cssSubject = academySubjects.Substring(6, 3);
            Console.WriteLine("Only CSS is-----" + cssSubject);

            string academySubjectsAgain = "HTML,CSS,Java Script,C#";

            string[] subjects = academySubjectsAgain.Split(',');
            
            string join = "";
            foreach (var subject in subjects)
            {
                Console.WriteLine("----->" + subject);
                join += subject + ", ";
            }
            Console.WriteLine(join);

            char[] characters = academySubjectsAgain.ToCharArray();
            foreach (var character in characters)
            {
                Console.WriteLine(character);
            }

            Console.ReadLine();

        }
    }
}
