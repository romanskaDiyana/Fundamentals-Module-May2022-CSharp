using System;
using System.Linq;

namespace _08CondenseArrayToNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //08.Condense Array to Number
            //Create a program to read an array of integers and condense them by summing all adjacent couples of elements until a single integer remains.

            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            while (numbers.Length > 1)
            {
                int[] condensedArray = new int[numbers.Length - 1];

                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    int firstNumber = numbers[i];
                    int secondNumber = numbers[i + 1];
                    condensedArray[i] = firstNumber + secondNumber;
                }

                numbers = condensedArray;
            }

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
