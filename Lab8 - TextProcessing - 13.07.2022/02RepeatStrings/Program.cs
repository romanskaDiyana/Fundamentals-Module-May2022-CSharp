using System;

namespace _02RepeatStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //02. Repeat Strings
            //Create a Program That Reads an Array of Strings.
            //Each String is Repeated N Times, Where N is the Length of
            //the String. Print the Concatenated String.

            string[] words = Console.ReadLine().Split(' ');

            string result = "";

            foreach (string word in words)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    result += word;
                }
            
            }
            Console.WriteLine(result);
        }
    }
}
