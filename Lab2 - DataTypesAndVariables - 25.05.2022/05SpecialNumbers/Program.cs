using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace _05SpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //05. Special Numbers
            //A number is special when its sum of digits is 5, 7, or 11.
            //Write a program to read an integer n and for all numbers in the range 1…n to print the number and if it is special or not (True / False).

            int endOfdigits = int.Parse(Console.ReadLine());

            for (int i = 1; i <= endOfdigits; i++)
            {
                int sumOfDigits = 0;

                int currentNum = i;

                while (currentNum != 0)
                {
                    sumOfDigits += currentNum % 10;
                    currentNum = currentNum / 10;
                }

                if (sumOfDigits == 5 || sumOfDigits == 7 || sumOfDigits == 11)
                {
                    Console.WriteLine($"{i} -> True ");
                }
                else
                {
                    Console.WriteLine($"{i} -> False ");
                }
            }
        }
    }
}
