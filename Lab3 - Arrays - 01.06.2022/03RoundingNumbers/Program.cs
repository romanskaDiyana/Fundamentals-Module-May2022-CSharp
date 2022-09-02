using System;
using System.Linq;

namespace _03RoundingNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //03. Rounding Numbers
            //Read an array of real numbers (space separated), round them in "away from 0" style and print the output as in the examples:

            double[] numbers = Console.ReadLine().Split(" ").Select(double.Parse).ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == 0) numbers[i] = 0;
                Console.WriteLine($"{numbers[i]} => {(int)Math.Round(numbers[i], MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
