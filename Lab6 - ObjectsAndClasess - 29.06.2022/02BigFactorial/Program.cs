using System;
using System.Numerics;

namespace _02BigFactorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //02. Big Factorial
            //You will receive a number N in the range [0…1000].
            //Calculate the Factorial of N and print out the result.


            int number = int.Parse(Console.ReadLine());

            BigInteger factorial = 1;


            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            Console.WriteLine(factorial);


            //int number = int.Parse(Console.ReadLine());

            //FactorialCalculator calculator = new FactorialCalculator(number);

            //Console.WriteLine(calculator.Calculate());
        }
    }
}
