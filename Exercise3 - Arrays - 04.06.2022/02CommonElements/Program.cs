using System;
using System.Collections.Generic;
using System.Linq;

namespace _02CommonElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //02.CommonElements
            //Create a program that prints out all common elements in two arrays. You have to compare the elements of the second array to the elements of the first.

            string[] arrayOne = Console.ReadLine().Split().ToArray();

            string[] arrayTwo = Console.ReadLine().Split().ToArray();

            List<string> commonElements = new List<string>();

            for (int i = 0; i < arrayTwo.Length; i++)
            {
                for (int j = 0; j < arrayOne.Length; j++)
                {
                    if (arrayOne[j] == arrayTwo[i])
                    {
                        commonElements.Add(arrayOne[j]);
                    }
                }
            }

            foreach (var element in commonElements)
            {
                Console.Write(element +" ");
            }
        }
    }
}
