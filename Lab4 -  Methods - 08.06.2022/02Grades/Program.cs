using System;

namespace _02Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //02.Grades
            //Create a method that receives a grade between
            //2.00 and 6.00 and prints the corresponding grade definition:

            double gradesInput = double.Parse(Console.ReadLine());

            PrintResult(gradesInput);

            static void PrintResult(double gradesInput)
            {
                if (gradesInput < 2.99)
                {
                    Console.WriteLine("Fail");
                }
                else if (gradesInput >= 3.00 && gradesInput <= 3.49)
                {
                    Console.WriteLine("Poor");
                }
                else if (gradesInput >= 3.50 && gradesInput <= 4.49)
                {
                    Console.WriteLine("Good");
                }
                else if (gradesInput >= 4.50 && gradesInput <= 5.49)
                {
                    Console.WriteLine("Very good");
                }
                else if (gradesInput >= 5.50 && gradesInput <= 6.00)
                {
                    Console.WriteLine("Excellent");
                }
            }
        }
    }
}
