using System;

namespace _08MathPower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //08. Math Power
            //Create a method, which receives two numbers as parameters:
            //   • The first number – the base
            //   • The second number – the power
            //The method should return the base raised to the given power.

            double firstNumber = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            Console.WriteLine(MathPower(firstNumber, power));
        }

        static double MathPower(double firstNumber, int power)
        {
            double result = 1;
            for (int i = 0; i < power; i++)
            {
                result *= firstNumber;
            }

            return result;
        }
    
    }
}
