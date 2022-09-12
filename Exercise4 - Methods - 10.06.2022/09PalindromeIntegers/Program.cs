using System;

namespace _09PalindromeIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //09.Palindrome Integers
            //Create a program that reads positive integers until you receive
            //the "END" command.  For each number, print whether the number
            //is a palindrome or not.
            //A palindrome is a number that reads the same backward as forward,
            //such as 323 or 1001. 

            string input = Console.ReadLine();

            while (input!= "END")
            {
                bool isIntegerPalindrome = IsNumberPalindrome(input);

                Console.WriteLine(isIntegerPalindrome.ToString().ToLower());
                input = Console.ReadLine();

            }
        }

        static bool IsNumberPalindrome(string input)
        {
            int number = int.Parse(input);

            if (number >= 0 && number <= 9)
            {
                return true;
            }

            for (int i = 0; i < input.Length/2; i++)
            {
                if (input[i] == input[input.Length - 1])
                {
                    return true;
                }
            }
            return false;
        }
    }
}
