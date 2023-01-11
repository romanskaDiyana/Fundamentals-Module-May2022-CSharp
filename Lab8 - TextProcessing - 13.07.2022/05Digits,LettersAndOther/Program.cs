using System;
using System.Collections.Generic;

namespace _05Digits_LettersAndOther
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //05.Create a program that receives a single string
            //and on the first line prints all the digits,
            //on the second – all the letters, and on the third
            //– all the other characters.
            //There will always be at least one digit, one letter
            //and one other characters.

            string[] stringInput = Console.ReadLine().Split();

            char[] eachChar = new char[stringInput.Length];
            List<string> isNumber = new List<string>();
            List<string> isLetter = new List<string>();
            List<string> isDigit = new List<string>();

            for (int i = 0; i < stringInput.Length; i++)
            {
                eachChar = stringInput[i].ToCharArray();

                for (int j = 0; j < eachChar.Length; j++)
                {
                    string stringConvert = eachChar[j].ToString();

                    if (char.IsDigit(eachChar[j]))
                    {
                        isNumber.Add(stringConvert);
                    }
                    else if (char.IsLetter(eachChar[j]))
                    {
                        isLetter.Add(stringConvert);
                    }
                    else
                    {
                        isDigit.Add(stringConvert);
                    }
                }

                Console.WriteLine(string.Join("", isNumber));
                Console.WriteLine(string.Join("", isLetter));
                Console.WriteLine(string.Join("", isDigit));
            
            }
        }
    }
}
