using System;

namespace _06ReplaceRepeatingChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //06. Replace Repeating Chars
            //Create a program that reads a string from the console and replaces any sequence of the same letter with a single corresponding letter.


            string text = Console.ReadLine();


            char previousChar = text[0];

            Console.Write(previousChar);

            for (int i = 0; i < text.Length; i++)
            {
                char currentChar = text[i]; 

                if (previousChar != currentChar)
                {
                    previousChar = currentChar;
                    Console.Write(previousChar);
                }
            }
        }
    }
}
