using System;
using System.Collections.Generic;
using System.Linq;

namespace _05Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //05. Courses
            //Create a program that keeps the information about courses. Each course has a name and registered students.
            //            You will be receiving a course name and a student name, until you receive the command "end".Check if such a course already exists, and if not, add the course.Register the user into the course. When you receive the command "end", print the courses with their names and total registered users. For each contest print the registered users.
            //            Input
            //    • Until the "end" command is received, you will be receiving input in the format: "{courseName} : {studentName}".
            //    • The product data is always delimited by " : ".
            //Output
            //    • Print the information about each course in the following the format: 
            //"{courseName}: {registeredStudents}"
            //    • Print the information about each student in the following the format:
            //"-- {studentName}"

            var coursesInfo = new Dictionary<string, List<string>>();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] tokens = command.Split(": ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string courseName = tokens[0].TrimEnd();
                string studentName = tokens[1];

                if (!coursesInfo.ContainsKey(courseName))
                {
                    coursesInfo[courseName] = new List<string>();

                }

                coursesInfo[courseName].Add(studentName);

                command = Console.ReadLine();
            }

            PrintCoursesInformation(coursesInfo);
        }

        public static void PrintCoursesInformation(Dictionary<string, List<string>> coursesInfo)
        {
            foreach (var kvp in coursesInfo)
            {
                string courseName = kvp.Key;
                var students = kvp.Value;

                Console.WriteLine($"{courseName}: {students.Count}");

                foreach (var student in students)
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
