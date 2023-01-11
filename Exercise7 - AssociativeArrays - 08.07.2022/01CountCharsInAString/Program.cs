
using System;
using System.Collections.Generic;

namespace _01CountCharsInAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //01.Count Chars In A String
            //Create a program that counts all characters in a string, except for space (' '). 
            //Print all the occurrences in the following format:
            //"{char} -> {occurrences}"


            char[] word = Console.ReadLine().ToCharArray();

            Dictionary<char, int> charOccurrences = new Dictionary<char, int>();

            foreach (char character in word)
            {
                if (character == ' ') continue;

                if (!charOccurrences.ContainsKey(character))
                {
                    charOccurrences.Add(character, 0);
                }

                charOccurrences[character]++;

            }

            foreach (var letter in charOccurrences)
            {
                Console.WriteLine($"{letter.Key} -> {letter.Value}");
            }
        }
    }
}
