using System;

namespace _06MiddleCaharcters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //06.Middle Characters
            //You will receive a single string. Create a method that prints the character
            //found at its middle. If the length of the string is even, there are two middle characters.

            string text = Console.ReadLine();

            PrintMiddleCharacters(text);

        }
        
        static void PrintMiddleCharacters(string text)
        {
            if (text.Length % 2 == 0)
            {
                Console.Write(text[text.Length / 2 - 1]);
                Console.WriteLine(text[text.Length / 2]);
            }
            else
            {
                Console.WriteLine(text[text.Length / 2]);
            }
        }
    }
}
