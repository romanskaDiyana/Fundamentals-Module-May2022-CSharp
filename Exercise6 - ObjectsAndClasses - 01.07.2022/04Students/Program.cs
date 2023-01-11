using System;
using System.Collections.Generic;
using System.Linq;

namespace _04Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //04. Students
            //Create a program that sorts some students by their grade in descending order.
            //Each student should have:
            //    • First name(String)
            //    • Last name(String)
            //    • Grade(a floating - point number)
            //Input
            //    • On the first line, you will receive a number n - the count of all students.
            //    • On the next n lines, you will be receiving information about these students
            //    in the following format: "{first name} {second name} {grade}".
            //Output
            //    • Print out the information about each student in the following format:
            //    "{first name} {second name}: {grade}".

            int numberOfStudents = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();

            for (int i = 0; i < numberOfStudents; i++)
            {
                string[] currStudentInfo = Console.ReadLine().Split(" ");

                var student = new Student(currStudentInfo[0], currStudentInfo[1], double.Parse(currStudentInfo[2]));

                students.Add(student);
            }

            students = students.OrderByDescending(currentStudent => currentStudent.Grade).ToList();

            students.ForEach(student => Console.WriteLine(student));

        }
    }

    class Student
    {
        public Student(string firstName, string lastName, double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade:f2}";
        }
    }
}
