using System;

namespace _09SumOfOddNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //09. Sum Of Odd Numbers
            //Create a program that prints on a new line the next n odd numbers (starting from 1).
            //On the last row print the sum of all n odd numbers.
            //            Input
            //            A single number n is read from the console,
            //            indicating how many odd numbers need to be printed.
            //Output
            //Print the next n odd numbers, starting from 1, separated by new lines.
            //On the last line, print the sum of these numbers.
            //Constraints
            //• n will be in the interval[1…100]

            int howManyOddNumbersToPrint = int.Parse(Console.ReadLine());

            int sumOfNumbers = 0;

            PrintOddNumbersAndSum(howManyOddNumbersToPrint, sumOfNumbers);

        }

        static void PrintOddNumbersAndSum(int howManyOddNumbersToPrint, int sumOfNumbers)
        {
            for (int i = 1; i < howManyOddNumbersToPrint * 2; i += 2)
            {
                Console.WriteLine(i);
                sumOfNumbers += i;
            }

            Console.WriteLine($"Sum: {sumOfNumbers}");
        }
    }
}
