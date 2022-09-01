using System;

namespace _04SumOfChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //04. Sum Of Chars
            //Create a program, which sums the ASCII codes of n characters and prints the sum on the console.

            int numberOfLetters = int.Parse(Console.ReadLine());

            char[] chars = new char[numberOfLetters];

            int sumOfDigits = 0;
            for (int i = 0; i < chars.Length; i++)
            {
                chars[i] = char.Parse(Console.ReadLine());
                int currentDigit = chars[i];
                sumOfDigits += currentDigit;
            }

            Console.WriteLine($"The sum equals: {sumOfDigits}");
        }
    }
}
