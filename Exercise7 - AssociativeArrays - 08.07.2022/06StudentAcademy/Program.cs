using System;
using System.Collections.Generic;
using System.Linq;

namespace _06StudentAcademy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //06. Student Academy
            //Create a program that keeps the information about students and their grades. 
            //You will receive n pair of rows.First, you will receive the student's name,
            //after that, you will receive their grade. Check if the student already exists
            //and if not, add him. Keep track of all grades for each student.
            //When you finish reading the data, keep the students with an average
            //grade higher than or equal to 4.50.

            //Print the students and their average grade in the following format:
            //            "{name} –> {averageGrade}"
            //Format the average grade to the 2nd decimal place.

            var students = new Dictionary<string, List<double>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string studentName = Console.ReadLine();
                double studentGrade = double.Parse(Console.ReadLine());

                if (!students.ContainsKey(studentName))
                {
                    students[studentName] = new List<double>();

                }
                students[studentName].Add(studentGrade);
            }

            foreach (var student in students)
            {
                string studentName = student.Key;
                double studentAverageGrade = student.Value.Average();
                if (student.Value.Average() >= 4.5)
                {
                    Console.WriteLine($"{studentName} -> {studentAverageGrade:f2}");
                }
            }
        }
    }
}
