using System;

namespace _12EvenNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //12. Even Number
            //Create a program that reads a sequence of numbers. If the number is even,
            //print its absolute value in the following format: "The number is: {number}"
            //and terminate the program. If the number is odd, print "Please write an even number."
            //and continue reading numbers.

            while (true)
            {
                int number = int.Parse(Console.ReadLine());

                if (number % 2 != 0)
                {
                    Console.WriteLine("Please write an even number.");
                    continue;
                    number = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine($"The number is: {Math.Abs(number)}");
                    break;
                }
            }
        }
    }
}
