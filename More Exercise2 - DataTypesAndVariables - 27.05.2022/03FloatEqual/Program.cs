using System;
using System.ComponentModel;
using System.Drawing;
using System.Reflection.Metadata;

namespace _03FloatEqual
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3. Floating Equality
            //Write a program that safely compares floating - point numbers(double) with precision eps = 0.000001.Note that we cannot directly compare two floating - point numbers a and b by a== b, because of the nature of the floating - point arithmetic.Therefore, we assume two numbers are equal if they are more close to each other than some fixed constant eps. 

            decimal firstNumber = decimal.Parse(Console.ReadLine());
            decimal secondNumber = decimal.Parse(Console.ReadLine());

            decimal eps = 0.000001m;
            bool isTrue = true;

            decimal compare = Math.Abs(firstNumber - secondNumber);

            if (compare >= eps)
            {
                isTrue = false;
                Console.WriteLine("False");
            }
            else
            {
                isTrue = true;
                Console.WriteLine("True");
            }
        }
    }
}
