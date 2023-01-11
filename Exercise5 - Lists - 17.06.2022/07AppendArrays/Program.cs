using System;
using System.Collections.Generic;
using System.Linq;

namespace _07AppendArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //07. Append Arrays
            //Create a program to append several arrays of numbers one after another.
            //• Arrays are separated by '|'
            //• Their values are separated by spaces(' ', one or several)
            //• Take all arrays starting from the rightmost and going to the
            //left and place them in a new array in that order

            var numbersAsStrings = Console.ReadLine().Split('|').Reverse().ToList();

            var numbers = new List<int>();
            foreach (var number in numbersAsStrings)
            {
                numbers.AddRange(number.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
