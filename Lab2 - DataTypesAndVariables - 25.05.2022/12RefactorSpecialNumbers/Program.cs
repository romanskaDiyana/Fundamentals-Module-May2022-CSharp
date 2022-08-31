using System;

namespace _12RefactorSpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //12.Refactor Special Numbers
            //You are given a working code that is a solution to Problem
            //5.Special Numbers.However, the variables are improperly named,
            //declared before they are needed and some of them are used
            //for multiple purposes. Without using your previous solution,
            //modify the code, so that it is easy to read and understand.


            int numberOfDigits = int.Parse(Console.ReadLine());

            for (int loopNumber = 1; loopNumber <= numberOfDigits; loopNumber++)
            {
                int sumOfDigits = 0;

                int currentNum = loopNumber;

                while (loopNumber > 0)
                {
                    sumOfDigits += loopNumber % 10;
                    loopNumber = loopNumber / 10;
                }

                bool isSpecial = false;
                isSpecial = (sumOfDigits == 5) || (sumOfDigits == 7) || (sumOfDigits == 11);

                Console.WriteLine("{0} -> {1}", currentNum, isSpecial);

                sumOfDigits = 0;
                loopNumber = currentNum;
            }
        }
    }
}
