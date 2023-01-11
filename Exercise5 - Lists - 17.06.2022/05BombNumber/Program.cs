using System;
using System.Collections.Generic;
using System.Linq;

namespace _05BombNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //05. Bomb Numbers
            //Create a program that reads a sequence of numbers and a special
            //bomb number holding a certain power. Your task is to detonate
            //every occurrence of the special bomb number and according to its
            //power the numbers to its left and right. The bomb power refers to
            //how many numbers to the left and right will be removed, no matter their values.
            //Detonations are performed from left to right and all the detonated numbers disappear.
            //Finally, print the sum of the remaining elements in the sequence.


            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] tokens = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int bombNumber = tokens[0];
            int power = tokens[1];

            for (int i = 0; i < numbers.Count; i++)
            {
                int target = numbers[i];
                if (target == bombNumber)
                {
                    BombNumber(numbers, power, i);

                }
            }

            Console.WriteLine(numbers.Sum());
        }

        private static void BombNumber(List<int> numbers, int power, int index)
        {
            int start = Math.Max(0, index - power);
            int end = Math.Min(numbers.Count - 1, index + power);
            for (int i = start; i <= end; i++)
            {
                numbers[i] = 0;
            }
        }
    }
}
