using System;
using System.Collections.Generic;

namespace _04.PrintAndSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //04.Print and Sum
            //You will receive two whole numbers from the console representing the start and the end of a sequence of numbers. 
            //        Your task is to print two lines:
            //• On the first line, print all numbers from the start of the sequence to the end inclusive
            //• On the second line, print the sum of the sequence in the format: "Sum: {sum}"

            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            int sumOfBothNumbers = 0;

            SumOfNumbers(firstNumber, secondNumber,sumOfBothNumbers);
        }

        static void SumOfNumbers(int firstNumber, int secondNumber, int sumOfBothNumbers)
        {
            for (int i = firstNumber; i <= secondNumber; i++)
            {
                sumOfBothNumbers += i;
                Console.Write(i + " ");
            }

            Console.WriteLine();
            Console.WriteLine($"Sum: {sumOfBothNumbers}");
        }
    }
}
