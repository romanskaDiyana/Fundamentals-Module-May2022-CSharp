using System;

namespace _04CaesarCipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //04. Caesar Cipher
            //Create a program that returns an encrypted version of the same text. Encrypt the text by shifting each character with three positions forward. For example, A would be replaced by D, B would become E and so on. Print the encrypted text.

            string input = Console.ReadLine();

            string encryptedString = string.Empty;

            foreach (char currentChar in input)
            {
                int currentPosition = currentChar;
                currentPosition += 3;
                encryptedString += (char)currentPosition;        
            }

            Console.WriteLine(encryptedString); 
        }
    }
}
    