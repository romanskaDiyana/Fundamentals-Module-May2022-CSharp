using System;

namespace _02VowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //02. Vowels Count
            //Create a method that receives a single string and prints
            //out the number of vowels contained in it.

            string inputText = Console.ReadLine().ToLower();

            CountVowels(inputText);
        }

        static void CountVowels(string inputText)
        {
            int counterVowels = 0;

            for (int i = 0; i < inputText.Length; i++)
            {
                if (inputText[i] == 'a' 
                    || inputText[i] == 'o' 
                    || inputText[i] == 'u'
                    || inputText[i] == 'e' 
                    || inputText[i] == 'i')
                {
                    counterVowels++; ;
                }
            }

            Console.WriteLine(counterVowels);
        }
    }
}
