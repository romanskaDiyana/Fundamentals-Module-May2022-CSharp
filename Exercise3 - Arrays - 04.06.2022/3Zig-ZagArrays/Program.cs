using System;
using System.Collections.Generic;
using System.Linq;

namespace _3Zig_ZagArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //03.Zig-Zag Array
            //Create a program that creates 2 arrays. You will be given an integer n. On the next n lines, you will get 2 integers. Form 2 new arrays in a zig-zag pattern as shown below.

            int numberOfPairs = int.Parse(Console.ReadLine());

            List<int> firstList = new List<int>();
            List<int> secondList = new List<int>();

            for (int i = 0; i < numberOfPairs; i++)
            {
                int[] pairs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                if (i % 2 == 0)
                {
                    firstList.Add(pairs[0]);
                    secondList.Add(pairs[1]);
                }
                else
                {
                    firstList.Add(pairs[1]);
                    secondList.Add(pairs[0]);
                }
                
            }
            Console.WriteLine(String.Join(" ", firstList));
            Console.WriteLine(String.Join(" ", secondList));
        }
    }
}
