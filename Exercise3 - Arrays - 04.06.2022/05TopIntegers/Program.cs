using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace _05TopIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //05. Top Integers
            //Create a program to find all the top integers in an array. A top integer is an integer that is greater than all the elements to its right.

            int[] intArray = Console.ReadLine().Split().Select(int.Parse).ToArray();


            for (int i = 0; i < intArray.Length; i++)
            {
                int currentIndex = intArray[i];

                bool isBiggest = true;

                for (int j = i + 1; j < intArray.Length; j++)
                {
                    int nextIndex = intArray[j];

                    if (currentIndex <= nextIndex)
                    {
                        isBiggest = false;
                        break;
                    }
                }

                if (isBiggest)
                {
                    Console.Write($"{currentIndex} ");
                }
            }
        }
    }
}
