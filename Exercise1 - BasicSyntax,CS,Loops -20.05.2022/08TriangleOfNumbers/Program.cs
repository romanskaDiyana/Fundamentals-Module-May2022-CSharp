using System;

namespace _08TriangleOfNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //08. Triangle of numbers
            //Write a program, which receives a number – n, and prints a triangle from 1 to n.
            //Constraints
            //    • n will be in the interval[1...20].

            int number = int.Parse(Console.ReadLine());

            TriangleOfNumbers(number);
        }

        static void TriangleOfNumbers(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
