using System;

namespace _01SmallestofThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //01.Smallest of Three Numbers
            //Create a method that prints out the smallest of three integer numbers.

            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int numberThree = int.Parse(Console.ReadLine());

            Console.WriteLine(SmallestNumber(numberOne,numberTwo,numberThree));

            //PrintTheSmallestNumber(numberOne,numberTwo,numberThree);
        }

        static int SmallestNumber(int a, int b, int c)
        {
            return Math.Min(a, Math.Min(b, c));
        }

       // static void PrintTheSmallestNumber(int a, int b, int c)
        //{
        //    Console.WriteLine(Math.Min(a, Math.Min(b, c)));
        //}
    }
}
