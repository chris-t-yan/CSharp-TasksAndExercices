using System;
using _06Class_excercise03_LINQ.Db;
using _06Class_excercise03_LINQ.Entities;
using System.Linq;

namespace _06Class_excercise03_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            TestDb.InitDb();
            var bobSql = from x in TestDb.Students
                         where x.FirstName == "Bob"
                         select x;

            var bobMethod = TestDb.Students.Where(x => x.FirstName == "Bob");

            var fullNamesSql = from student in TestDb.Students
                               select new StundetBasicInfo
                               {
                                   FullName = $"{student.FirstName}{student.LastName}"
                               };

            foreach (var studentInfo in fullNamesSql)
            {
                Console.WriteLine(studentInfo.FullName);
            }

            var cSharpBasicStudentsSql = (from student in TestDb.Students
                                       where student.Subjects.Contains ((from subject in TestDb.Subjects
                                                                        where subject.Name =="C# Basic"
                                                                        select subject).FirstOrDefault())
                                      select student);

            var cSharpBasicStudentsMethod = TestDb.Students
                .Where(student => student.Subjects.Contains(
                    TestDb.Subjects.FirstOrDefault(subject => subject.Name == "C# Bascic")))
                .Select(student => student)
                .FirstOrDefault();


        }
    }
}
