using System;
using System.Collections.Generic;

namespace _01ReverseStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //01.Reverse Strings
            //You will be given series of strings until you
            //receive an "end" command. Write a program that reverses
            //strings and prints each pair on separate line in format
            //"{word} = {reversed word}".

            string input = Console.ReadLine();

            List<string> words = new List<string>();   
            
            string reversedWord = "";

            while (input != "end")
            {

                for (int i = input.Length - 1; i >= 0; i--)
                {
                    reversedWord += input[i];
                }

                words.Add(reversedWord);

                Console.WriteLine($"{input} = {reversedWord}");

                reversedWord = "";

                input = Console.ReadLine();
            }      
        }
    }
}
