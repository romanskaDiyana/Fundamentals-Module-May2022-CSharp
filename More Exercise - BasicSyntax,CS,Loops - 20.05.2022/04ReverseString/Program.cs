using System;
using System.Collections.Generic;
using System.Linq;

namespace _04ReverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //04.Reverse String
            //Create a program which reverses a string and print it on the console.

            List<char> letterList = Console.ReadLine().ToList();

            letterList.Reverse();

            foreach (char letter in letterList)
            {
                Console.Write(string.Join(" ", letter));
            }
        }
    }
}
