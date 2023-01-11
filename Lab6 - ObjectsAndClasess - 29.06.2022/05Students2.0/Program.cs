using System;
using System.Collections.Generic;

namespace _05Students2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            //05.Students 2.0
            //Define a class called Student, which will hold the following information about some students: 
            //    • first name
            //    • last name
            //    • age
            //    • home town
            //Input / Constraints
            //Read information about some students, until you receive the "end" command.
            //After that, you will receive a city name.
            //Output
            //Print the students who are from the given city in the following
            //format: "{firstName} {lastName} is {age} years old."
            // If you receive a student, which already exists
            // (first name and last name should be unique) overwrite the information.

            List<Student> listOfStudents = new List<Student>();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] studentsInformation = command.Split(' ');   

                string firstName = studentsInformation[0];
                string lastName = studentsInformation[1];
                int age  = int.Parse(studentsInformation[2]);
                string homeTown = studentsInformation[3];

                Student newStudent = new Student(firstName, lastName, age, homeTown);

                if (IsStudentExisting(studentsInformation[0], studentsInformation[1], listOfStudents))
                {
                    Student student = listOfStudents.Find(student => student.FirstName == studentsInformation[0] && student.LastName == studentsInformation[1]);
                    student.Age = int.Parse(studentsInformation[2]);
                    student.HomeTown = studentsInformation[3];
                }
                else
                {
                    Student student = new Student(studentsInformation[0], studentsInformation[1], int.Parse(studentsInformation[2]), studentsInformation[3]);
                    listOfStudents.Add(student);
                }

                command = Console.ReadLine();
            }

            string filter = Console.ReadLine();

            foreach (Student currentStudent in listOfStudents)
            {
                if (filter == currentStudent.HomeTown)
                {
                    Console.WriteLine($"{currentStudent.FirstName} {currentStudent.LastName} is {currentStudent.Age} years old.");
                }
            }

        }

        static bool IsStudentExisting(string firstName, string lastName, List<Student> students)
        {
            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    return true;
                }
            }

            return false;
        }
    }
}

    class Student
    {
        public Student(string firstName, string lastName, int age, string homeTown)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.HomeTown = homeTown;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }    
        public string HomeTown { get; set; }
    }

