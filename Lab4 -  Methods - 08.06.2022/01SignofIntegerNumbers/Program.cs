using System;
using System.ComponentModel.Design;

namespace _01SignofIntegerNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //01.SignOfIntegerNumber
            //A single integer is given, create a method that checks if the given number is positive, negative, or zero. As a result print:
            //For positive number: "The number {number} is positive."
            //For negative number: "The number {number} is negative. "
            //For zero number: "The number {number} is zero. "

            int number = int.Parse(Console.ReadLine());

            PrintSign(number);

            static void PrintSign(int number)
            {
                if (number > 0)
                {
                    Console.WriteLine($"The number {number} is positive.");
                }
                else if (number < 0)
                {
                    Console.WriteLine($"The number {number} is negative.");
                }
                else if (number == 0)
                {
                    Console.WriteLine($"The number {number} is zero.");
                }
            }
        }
    }
}
