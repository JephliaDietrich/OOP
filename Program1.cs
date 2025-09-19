using ConsoleApp1;
using System;
using System.Xml.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Liza", 19, 61, 2);
            student.GetStudentInfo();
            Console.WriteLine();

            student.EditStudent();

            Console.Write($"_New student information_ ");
            Console.WriteLine();
            Console.WriteLine();

            student.GetStudentInfo();

            Console.WriteLine();
            Console.WriteLine();

            student.RatingStud();

            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine(student.CourseStud());
        }
    }
}