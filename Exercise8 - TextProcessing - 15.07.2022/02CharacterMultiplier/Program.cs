using System;

namespace _02CharacterMultiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //02. Character Multiplayer
            //Create a method that takes two strings as arguments and returns the sum of their character codes multiplied. Multiply str1[0] with str2[0] and add to the total sum. Then continue with the next two characters. If one of the strings is longer than the other, add the remaining character codes to the total sum without multiplication.

           
            var input = Console.ReadLine().Split();

            GetStringSum(input[0], input[1]);                  

        }

        static void GetStringSum(string stringOne, string stringTwo)
        {
            int sum = 0;
            int minLenght = Math.Min(stringOne.Length, stringTwo.Length);


            for (int i = 0; i < minLenght; i++)
            {
                sum += stringOne[i] * stringTwo[i];
            }

            string longestLenght = stringOne;

            if (longestLenght.Length < stringTwo.Length)
            {
                longestLenght = stringTwo;  
            }

            for (int i = minLenght; i < longestLenght.Length; i++)
            {
                sum += longestLenght[i];
            }

            Console.WriteLine(sum);
        }
    }
}
