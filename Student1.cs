using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Student
    {

       private string name;
       private int age;
       private double rating;
       private int course;


        public Student(string name, int age, double rating, int course)
        {
            this.name = name;
            this.age = age;
            this.rating = rating;
            this.course = course;
        }

        public string Name
        {
            get { return name; }

            set {

                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine($"The name cannot be empty.");
                    name = "nothing";
                } else
                {
                    name = value;
                }

            }
        }


        public int Age
        {
            get { return age; }
            set
            {

                if(value < 0)
                {
                    Console.WriteLine($"Age cannot be negative.");
                    age = 0;
                }
                else
                {
                    age = value;
                }

            }
        }


        public double Rating
        {
            get { return rating; }
            set 
            { 
            
                if(value < 0)
                {
                    Console.WriteLine($"The rating cannot be negative.");
                    rating = 0; 
                } else
                {
                    rating = value;
                }

            }
        }



        public int Course
        {
            get { return course; }
            set 
            { 
            
                if (value < 1)
                {
                    Console.WriteLine($"You are not enrolled.");
                }
                else if (value > 7)
                {
                    Console.WriteLine($"You have already completed your studies.");
                } 
                else
                {
                    course = value;
                }

            }
        }


       public void GetStudentInfo()
        {
            Console.WriteLine($"Student name: {name}, age {age}, rating {rating}, course {course}");
        }



       public void EditStudent()
        {

            Console.WriteLine($"Enter updated information for the student.");
            Console.WriteLine();
            Console.Write($"Name: ");
            string? nameStud = Console.ReadLine();
            this.Name = nameStud;

            Console.WriteLine();
            Console.Write($"Age: ");
            string? ageStud = Console.ReadLine();
            int age1 = int.Parse(ageStud);
            this.Age = age1;

            Console.WriteLine();
            Console.Write($"Rating: ");
            string? ratingStud = Console.ReadLine();
            double rating1 = double.Parse(ratingStud);
            this.Rating = rating1;

            Console.WriteLine();
            Console.Write($"Course: ");
            string? courseStud = Console.ReadLine();
            int course1 = int.Parse(courseStud);
            this.Course = course1;
            Console.WriteLine();

        }


        public void RatingStud()
        {
            if (rating < 60)
            {
                Console.WriteLine($"You have {rating} points. You have a retake.");
            } else
            {
                Console.WriteLine($"You have {rating} points. You don't need to retake the exam.");
            }
            
        }


        
        public string CourseStud()
        {
            if (course > 0 && course <= 4)
            {

                return "Your course: Bachelor's degree.";

            }
            else if (4 < course && course <= 7)
            {

                return "Your course: Master's degree.";

            }
            else
            {

                return "Invalid course.";

            }
        }

    }
}
