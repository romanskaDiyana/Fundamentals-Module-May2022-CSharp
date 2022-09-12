using System;

namespace _08FactorialDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //08. Factorial Division
            //Read two integers. Calculate the factorial of each number.
            //Divide the first result by the second
            //and print the result of the division formatted to the second decimal point.


            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            double firstNumberFactorial = Factorial(firstNumber);
            double secondNumberFactorial = Factorial(secondNumber);

            Console.WriteLine($"{firstNumberFactorial / secondNumberFactorial:f2}");
        }

        static double Factorial(int number)
        {
            double result = 1;
            while (number != 1)
            {
                result *= number;
                number--;
            }

            return result;
        }     
    }
}
