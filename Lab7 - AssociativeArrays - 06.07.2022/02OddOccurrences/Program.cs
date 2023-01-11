using System;
using System.Collections.Generic;
using System.Linq;

namespace _02OddOccurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //02. Odd Occurrences
            //Create a program that extracts all elements from a given sequence
            //of words that are present in it an odd number of times (case-insensitive).
            //• Words are given on a single line, space - separated.
            //• Print the result elements in lowercase, in their order of appearance.


            string[] words = Console.ReadLine().ToLower().Split();

            Dictionary<string, int> dictionary = new Dictionary<string, int>();


            for (int i = 0; i < words.Length; i++)
            {
                if (!dictionary.ContainsKey(words[i]))
                {
                    dictionary.Add(words[i], 0);
                }
                dictionary[words[i]]++;
            }

            foreach (var word in dictionary)
            {
                if (word.Value % 2 == 1)
                {
                    Console.Write($"{word.Key} ");
                }
            }
        }
    }
}
