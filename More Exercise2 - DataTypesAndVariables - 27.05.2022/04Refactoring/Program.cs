using System;

namespace _4.Refactoring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4.Refactoring: Prime Checker
            //Your job is to modify it in a way that is easy to read and understand.

            int toNumber = int.Parse(Console.ReadLine());

            for (int fromNumber = 2; fromNumber <= toNumber; fromNumber++)
            {
                bool isPrime = true;
                for (int j = 2; j < fromNumber; j++)
                {
                    if (fromNumber % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{fromNumber} -> {isPrime.ToString().ToLower()}");
            }
        }
    }
}
