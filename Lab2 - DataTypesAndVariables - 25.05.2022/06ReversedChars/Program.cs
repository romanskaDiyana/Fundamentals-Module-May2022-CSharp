using System;

namespace _06ReversedChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //06. Reversed Chars
            //Create a program that takes 3 lines of characters and prints them in reversed order with a space between them.

            char[] chars = new char[3];
            chars[0] = char.Parse(Console.ReadLine());
            chars[1] = char.Parse(Console.ReadLine());
            chars[2] = char.Parse(Console.ReadLine());

            Array.Reverse(chars);

            foreach (var digit in chars)
            {
                Console.Write(digit + " ");
            }
        }
    }
}
