using System;
using System.Linq;

namespace _06EqualSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //06. Equal Sums 
            //Create a program that determines if an element exists in an array for which the sum of all elements to its left is equal to the sum of all elements to its right. If there are no elements to the left or right, their sum is considered to be 0. Print the index of the element that satisfies the condition or "no" if there is no such element.

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int leftSum = 0;
            int rightSum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers.Length == 1)
                {
                    Console.WriteLine(0);
                    return;
                }

                leftSum = 0;

                for (int sumLeft = i; sumLeft > 0; sumLeft--)
                {
                    int nextLeftElementPosition = sumLeft - 1;
                    if (sumLeft > 0)
                    {
                        leftSum += numbers[nextLeftElementPosition];
                    }
                }

                rightSum = 0;
                for (int j = i; j < numbers.Length; j++)
                {
                    int nextElementPositon = j + 1;
                    if (j < numbers.Length - 1)
                    {
                        rightSum += numbers[nextElementPositon];
                    }
                }

                if (rightSum == leftSum)
                {
                    Console.WriteLine(i);
                    return;
                }
            }

            Console.WriteLine("no");
        }
    }
}
