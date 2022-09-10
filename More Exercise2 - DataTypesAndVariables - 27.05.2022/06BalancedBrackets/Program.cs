using System;

namespace _06BalancedBrackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //06. Balanced Brackets
            //You will receive n lines. On those lines, you will receive one of the following:
            //• Opening bracket – “(“,
            //    • Closing bracket – “)” or
            //    • Random string
            //    Your task is to find out if the brackets are balanced.That means after every closing bracket should follow an opening one.Nested parentheses are not valid, and if two consecutive opening brackets exist, the expression should be marked as unbalanced.

            int numberOfLines = int.Parse(Console.ReadLine());

            BalancedBrackets(numberOfLines);
        }

        static void BalancedBrackets(int numberOfLines)
        {
            int openingBracket = 0;
            int closingBracket = 0;

            for (int i = 0; i < numberOfLines; i++)
            {
                string input = Console.ReadLine();

                if (input.Contains('(')) openingBracket++;
                else if (input.Contains(')')) closingBracket++;
            }

            if (openingBracket % closingBracket == 0) Console.WriteLine("BALANCED");
            else Console.WriteLine("UNBALANCED");
        }
    }
}
