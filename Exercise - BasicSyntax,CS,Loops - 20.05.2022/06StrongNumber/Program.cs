using System;


namespace _06StrongNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //06. Strong Number
            //Write a program that receives a single integer and calculates is it a strong or not.
            //A number is strong if the sum of the Factorial of each digit is equal to the number. 
            //Example: 145 is a strong number, because 1! + 4! + 5! = 145.
            //Print "yes" if the number is strong or "no" if the number is not strong.

            int strongNumber = int.Parse(Console.ReadLine());


            int strongNumberCopy = strongNumber;
            int sumOfnumbers = 0;


            while (strongNumber > 0)
            {
                int factorialNumber = 1;
                int currentNumber = strongNumber % 10;
                strongNumber /= 10;

                for (int i = 2; i <= currentNumber; i++)
                {
                    factorialNumber *= i;
                }

                sumOfnumbers += factorialNumber;
            }

            Console.WriteLine(sumOfnumbers == strongNumberCopy ? "yes" : "no");

        }
    }
}
