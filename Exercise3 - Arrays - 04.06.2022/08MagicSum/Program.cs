using System;
using System.Linq;

namespace _08MagicSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //08. Magic Sum
            //Create a program, which prints all unique pairs in an array of integers whose sum is equal to a given number.

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int magicNum = int.Parse(Console.ReadLine());

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] + numbers[j] == magicNum)
                    {
                        Console.WriteLine($"{numbers[i]} {numbers[j]}");
                    }
                }
            }
        }
    }
}
