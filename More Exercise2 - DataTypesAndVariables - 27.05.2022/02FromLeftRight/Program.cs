using System;
using System.Numerics;

namespace _02FromLeftRight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //02. From Left To Right
            //You will receive a number that represents how many lines we will get as input. On the next N lines, you will receive a string with 2 numbers, separated by a single space. You need to compare them. If the left number is greater than the right number, you need to print the sum of all digits in the left number, otherwise, print the sum of all digits in the right number.

            int countOfpairs = int.Parse(Console.ReadLine());

            BigInteger sumOfDigits = new BigInteger();

            for (int i = 0; i < countOfpairs; i++)
            {
                string[] pair = Console.ReadLine().Split();
                
                long firstPair = long.Parse(pair[0]);
                long secondPair = long.Parse(pair[1]);

                long biggestFromPair = Math.Max(firstPair, secondPair);

                char[] charArray = biggestFromPair.ToString().ToCharArray();

                for (int j = 0; j < charArray.Length; j++)
                {
                    sumOfDigits += long.Parse(charArray[j].ToString());
                }

                Console.WriteLine(sumOfDigits);

                sumOfDigits = 0;
            }           
        }
    }
}
