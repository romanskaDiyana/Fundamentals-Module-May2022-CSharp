using System;

namespace _09CharsToString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //09. Chars to String
            //Create a program that reads 3 lines of input. On each line, you get a single character. Combine all the characters into one string and print it on the console.

            char[] chars = new char[3];
            chars[0] = char.Parse(Console.ReadLine());
            chars[1] = char.Parse(Console.ReadLine());
            chars[2] = char.Parse(Console.ReadLine());

            foreach (char c in chars)
            {
                Console.Write(String.Join(" ", c));
            }
        }
    }
}
