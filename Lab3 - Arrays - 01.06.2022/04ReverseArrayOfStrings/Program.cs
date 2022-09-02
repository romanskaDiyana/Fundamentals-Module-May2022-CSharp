using Microsoft.VisualBasic;
using System;
using System.Linq;

namespace _04ReverseArrayOfStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4.Reverse Array of Strings
            //Create a program that reads an array of strings, reverses it, and prints its elements. The input consists of a sequence of space-separated strings.Print the output on a single line(space separated).

            string[] array = Console.ReadLine().Split(' ').ToArray();

            string[] reversedArray = new string[array.Length];  

            for (int i = 0; i < reversedArray.Length; i++)
            {
                reversedArray[i] = array[array.Length - i - 1];
            }

            foreach (string item in reversedArray)
            {
                Console.Write(item + " ");
            }

            //Array.Reverse(array);

            //foreach (string item in array)
            //{ 
            //    Console.Write(item + " ");
            //}
        }
    }
}
