using System;
using System.Collections.Generic;

namespace _05PrintASCIITable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //05.Print Part of the ASCII Table

            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            List<char> chars = new List<char>();

            for (int i = firstNumber; i <= secondNumber; i++)
            {
                int currentNumber = i;
                char currentChar = (char)(currentNumber);
                chars.Add(currentChar);
            }

            foreach (char currentChar in chars)
            {
                Console.Write(currentChar + " ");
            }
        }
    }
}
