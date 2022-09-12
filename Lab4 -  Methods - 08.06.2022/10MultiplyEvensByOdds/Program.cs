using System;

namespace _10MultiplyEvensByOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //10. Multiply Evens by Odds
            //Create a program that multiplies the sum of all even digits of a number by the sum of all odd digits of the same number:
            //• Create a method called GetMultipleOfEvenAndOdds()
            //• Create a method GetSumOfEvenDigits()
            //• Create GetSumOfOddDigits()
            //• You may need to use Math.Abs() for negative numbers

            int number = Math.Abs(int.Parse(Console.ReadLine()));

            int evenDigitSum = GetDigitsSum(number, 0);
            int oddDigitSum = GetDigitsSum(number, 1);

            Console.WriteLine(evenDigitSum * oddDigitSum);
        }

        static int GetDigitsSum(int number, int evenOddCheck) 
        {
            int sum = 0;

            while (number > 0 )
            {
                int digit = number % 10;

                if (digit % 2 == evenOddCheck)
                {
                    sum += digit;
                }

                number /= 10;
            }
            return sum;
        }
    }
}
