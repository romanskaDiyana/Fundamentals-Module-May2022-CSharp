using System;
using System.Collections.Generic;

namespace _01SortNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //01. Sort Numbers
            // Create a program that receives three real numbers and sorts them in descending order. Print each number on a new line.
            List<int> listOfNumbers = new List<int>();

            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            listOfNumbers.Add(firstNumber);
            listOfNumbers.Add(secondNumber);
            listOfNumbers.Add(thirdNumber);

            listOfNumbers.Sort();
            listOfNumbers.Reverse();

            foreach (int number in listOfNumbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
