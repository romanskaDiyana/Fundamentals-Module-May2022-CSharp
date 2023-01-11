using System;
using System.Collections.Generic;

namespace _04Students
{
    class Program
    {
        static void Main(string[] args)
        {
            //04.Students
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


            List<Student> listOfStudents = new List<Student>();

            string command = Console.ReadLine();

            while (command != "end")
            { 
                string[] studentInformation = command.Split(' ');

                string firstName = studentInformation[0];
                string lastName = studentInformation[1];
                int age = int.Parse(studentInformation[2]);
                string homeTown = studentInformation[3];

                Student newStudent = new Student(firstName, lastName, age, homeTown);
                
                listOfStudents.Add(newStudent);

                command = Console.ReadLine();
            }


            string townName = Console.ReadLine();

            foreach (Student currentStudent in listOfStudents)
            {
                if (townName == currentStudent.HomeTown)
                {
                    Console.WriteLine($"{currentStudent.FirstName} {currentStudent.LastName} is {currentStudent.Age} years old.");
                }
            }
        }
    }

    class Student
    {
        public Student(string firstName, string lastName, int age, string homeTown)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            HomeTown = homeTown;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }
    }
}
