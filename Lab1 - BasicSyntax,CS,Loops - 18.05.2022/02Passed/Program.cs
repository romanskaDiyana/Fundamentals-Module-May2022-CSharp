using System;

namespace _02Passed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //02. Passed
            //Create a program that receives a single number as an input representing a grade.
            //        Print in the console:
            //• "Passed!" if the grade is equal or more than 3.00.


            //Solution 3
            //-----------------------------------------------//
            double grade = double.Parse(Console.ReadLine());

            IsPassed(grade);

            static void IsPassed(double grade)
            {
                bool isPassed = false;
                if (grade >= 3)
                {
                    isPassed = true;
                    Console.WriteLine("Passed!");
                }
            }

            //Solution 2
            //----------------------------------------------------//
            //double grade = double.Parse(Console.ReadLine());

            //IsPassed(grade);

            //static void IsPassed(double grade)
            //{
            //    if (grade >= 3)
            //    {
            //        Console.WriteLine("Passed!");
            //    }
            //}

            //Solution 1
            //---------------------------------------------------//

            //double grade = double.Parse(Console.ReadLine());

            //if (grade >= 3)
            //{
            //    Console.WriteLine("Passed!");
            //}
        }
    }
}
