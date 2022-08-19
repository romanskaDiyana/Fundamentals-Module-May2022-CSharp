using System;

namespace _03PassedOrFailed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //03. Passed or Fail
            //Modify the program from the previous problem, so it will print "Failed!",
            //if the grade is lower than 3.00.
            //Input
            //The input comes as a single double number.
            //Output
            //The output is either "Passed!" if the grade is more than 2.99,
            //otherwise you should print "Failed!".


            //Solution 3
            //----------------------------------------------------------------//

            double grade = double.Parse(Console.ReadLine());

            PassedOrFailed(grade);

            static void PassedOrFailed(double grade)
            {
                bool isPassed = false;

                if (grade >= 3)
                {
                    isPassed = true;
                    Console.WriteLine("Passed!");
                }
                else
                {
                    isPassed = false;
                    Console.WriteLine("Failed!");
                }
            }

            //Solution 2
            //----------------------------------------------------------------//

            //double grade = double.Parse(Console.ReadLine());

            //PassedOrFailed(grade);

            //static void PassedOrFailed(double grade)
            //{
            //    if (grade>= 3)
            //    {
            //        Console.WriteLine("Passed!");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Failed!");
            //    }
            //}


            //Solution 1
            //----------------------------------------------------------------//

            //double grade = double.Parse(Console.ReadLine());

            //if (grade >= 3)
            //{
            //    Console.WriteLine("Passed!");
            //}
            //else
            //{
            //    Console.WriteLine("Failed!");
            //}
        }
    }
}
