using System;

namespace _03Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //03.Substring
            //On the first line you will receive a string. On the second line
            //you will receive a second string. Create a program that removes
            //all of the occurrences of the first string in the second until
            //there is no match. At the end print the remaining string.

            string wordToRemove = Console.ReadLine();

            string text = Console.ReadLine();


            int index = text.IndexOf(wordToRemove);

            while(index >= 0)
            {
                text = text.Remove(index, wordToRemove.Length);
                index = text.IndexOf(wordToRemove); 
            }

            Console.WriteLine(text);
        }
    }
}
