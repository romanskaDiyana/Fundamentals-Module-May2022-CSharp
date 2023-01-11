using System;
using System.Collections.Generic;
using System.Linq;

namespace _05RemoveNegativesAndReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //05.Remove Negatives and Reverse
            //Read a list of integers, remove all negative numbers from it
            //and print the remaining elements in reversed order.
            //If there are no elements left in the list, print "empty".

            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();


            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] < 0)
                {
                    list.Remove(list[i]);
                    i--;
                }
            }

            for (int i = 0; i < list.Count / 2; i++)
            {
                int reversedInts = list[i];
                list[i] = list[list.Count - i - 1];
                list[list.Count - i -1] = reversedInts;
             
            }

            if (list.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(String.Join(" ", list));
            }       
        }
    }
}
