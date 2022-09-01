using System;
using System.Linq;
using System.Runtime.Serialization.Formatters;

namespace _02SumDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //02. Sum Digits
            //Create a program that receives a single integer. Your task is to find the sum of its digits.
            //For example: 12345-> 1 + 2 + 3 + 4 + 5 = 15

            //Solution 2
            //---------------------------------------------------------//

            char[] charArray = Console.ReadLine().ToCharArray();

            int sumOfDigits = 0;

            for (int i = 0; i < charArray.Length; i++)
            {
                sumOfDigits += int.Parse(charArray[i].ToString());
            }

            Console.WriteLine(sumOfDigits);


            //Solution 1
            //-----------------------------------------------------------//

            //int integer = int.Parse(Console.ReadLine());

            //int sumOfDigits = 0;

            //while (integer != 0)
            //{
            //    int lastDigit = integer % 10;
            //    integer /= 10;

            //    sumOfDigits += lastDigit;
            //}

            //Console.WriteLine(sumOfDigits);
        }
    }
}
