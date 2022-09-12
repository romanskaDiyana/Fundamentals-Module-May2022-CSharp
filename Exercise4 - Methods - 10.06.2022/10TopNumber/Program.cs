using System;

namespace _10TopNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //10. Top Number
            //A top number is an integer that holds the following properties:
            //    • Its sum of digits is divisible by 8, e.g. 8, 17, 88
            //    • Holds at least one odd digit, e.g. 232, 707, 87578
            //    • Some examples of top numbers are: 17, 161, 251, 4310, 123200
            //Create a program to print all top numbers in the range[1…n].
            //You will receive a single integer from the console, representing the end value.


            int number = int.Parse(Console.ReadLine());

            TopNumber(number);
        }

        static void TopNumber(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                bool oddDigit = false;
                int singleNumber = i;
                int sumOfSingleNumbers = 0;

                while (singleNumber != 0)
                {
                    sumOfSingleNumbers += singleNumber % 10;

                    if ((singleNumber % 10) % 2 != 0)
                    {
                        oddDigit = true;
                    }

                    singleNumber /= 10;
                }

                if (oddDigit && sumOfSingleNumbers % 8 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
