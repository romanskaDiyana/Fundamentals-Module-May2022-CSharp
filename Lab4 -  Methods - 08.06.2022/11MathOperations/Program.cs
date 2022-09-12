using System;

namespace _11MathOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //11. Math Operations 
            //Write a method that receives two numbers and an operator,
            //calculates the result and returns it. You will be given three
            //lines of input. The first will be the first number,
            //the second one will be the operator and the last one will be the second number.
            //The possible operators are: /, *, +and -.

            double firstNumber = double.Parse(Console.ReadLine());
            string action = Console.ReadLine();
            double secondNumber = double.Parse(Console.ReadLine());

            Console.WriteLine(Calculate(firstNumber, action, secondNumber));
        }
        static double Calculate(double first, string action, double second)
        {
            double result = 0;

            switch (action)
            {
                case "+":
                    result = first + second; break;
                case "-":
                    result = first - second; break;
                case "*":
                    result = first * second; break;
                case "/":
                    result = first / second; break;
            }

            return result;
        }
    }
}
