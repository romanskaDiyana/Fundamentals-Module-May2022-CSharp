using System;
using System.Linq;

namespace _07EqualArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Read two arrays and determine whether they are identical or not. The arrays are identical, if all their elements are equal. If the arrays are identical, find the sum of the elements of one of them and print the following message to the console: "Arrays are identical. Sum: {sum}"

            int[] array1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] array2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int sumOfEquality = 0;

            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] == array2[i])
                {
                    sumOfEquality += array1[i];
                }
                else
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    return;
                }
            }

            Console.WriteLine($"Arrays are identical. Sum: {sumOfEquality}");
        }
    }
}
