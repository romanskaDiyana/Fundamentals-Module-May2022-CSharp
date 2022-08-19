using System;

namespace _01StudentInformation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //01. Student Information
            //Create a program that receives 3 lines of input:
            //    • student name 
            //    • age
            //    • average grade. 
            //Your task is to print all of the info about the student in the following format:
            //"Name: {student name}, Age: {student age}, Grade: {student grade}".



            //Solution 2
            //------------------------------------------------------------//


            string studentName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            double averageGrade = double.Parse(Console.ReadLine());

            PrintStudentInformation(studentName, age, averageGrade);


            static void PrintStudentInformation(string studentName, int age, double averageGrade)
            {
                Console.WriteLine($"Name: {studentName}, Age: {age}, Grade: {averageGrade:f2}");

            }


            //Solution 1
            //------------------------------------------------------------//

            //string studentName = Console.ReadLine();
            //int age = int.Parse(Console.ReadLine());
            //double averageGrade = double.Parse(Console.ReadLine());

            //Console.WriteLine($"Name: {studentName}, Age: {age}, Grade: {averageGrade:f2}");
        }
    }
}
