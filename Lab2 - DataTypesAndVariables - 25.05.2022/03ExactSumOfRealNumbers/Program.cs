using System;
using System.Numerics;

namespace _03ExactSumOfRealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //03. Exact Sum of Real Numbers
            //Create a program to enter n numbers and calculate and print their exact sum (without rounding).

            int number = int.Parse(Console.ReadLine());

            decimal sumOfNumbers = 0;

            for (int i = 0; i < number; i++)
            {
                decimal numbers = decimal.Parse(Console.ReadLine());

                sumOfNumbers += numbers;
            }

            Console.WriteLine(sumOfNumbers);
        }
    }
}
