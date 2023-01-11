using System;
using System.Collections.Generic;
using System.Linq;

namespace _01SumAdjacentEqualNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //01.Sum Adjacent Equal Numbers
            //Create a program to sum all of the adjacent equal numbers in a list of decimal numbers,
            //starting from left to right.
            //• After two numbers are summed, the result could be equal to some of
            //its neighbors and should be summed as well (see the examples below)
            //• Always sum the leftmost two equal neighbors(if several couples of 
            //equal neighbors are available)


            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; i < list.Count + 1; i++)
            {
                if (list[i] == list[i + 1])
                {
                    list[i] += list[i + 1];
                    list.RemoveAt(i + 1);
                    i--;
                }
            }
            Console.Write(String.Join(" ", list));
        }
    }
}
