using System;

namespace _03CharactersInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //03. Characters in Range 
            //Create a method that receives two characters and prints all
            //the characters between them according to ASCII (on a single line).
            //NOTE: If the second letter's ASCII value is less than that
            //of the first one, then the two initial letters should be swapped.

            char charOne = char.Parse(Console.ReadLine());
            char charTwo = char.Parse(Console.ReadLine());

            CharactersInRange(charOne,charTwo);
        }

        static void CharactersInRange(char charOne, char charTwo)
        {
            int startChar = Math.Min(charOne, charTwo);
            int endChar = Math.Max(charOne, charTwo);

            for (int i = startChar + 1; i < endChar; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}
