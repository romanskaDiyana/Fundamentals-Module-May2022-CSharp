using System;

namespace _01RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {

            //01. Randomize Words 
            //You will be given a string that will
            //contain words separated by a single space.
            //Randomize their order and print each word on a new line.


            string[] words = Console.ReadLine().Split();

            Random randomize = new Random();


            for (int i = 0; i < words.Length; i++)
            {
                int newIndex = randomize.Next(words.Length);

                string newWord = words[i];


                words[i] = words[newIndex];
                words[newIndex] = newWord;
            }

            Console.WriteLine(string.Join("\n", words));

            //string[] words = Console.ReadLine().Split(' ');

            //Random random = new Random();   

            //for (int i = 0; i < words.Length; i++)
            //{
            //    int swapPossition = random.Next(words.Length);  


            //    string word = words[i];
            //    words[i] = words[swapPossition];
            //    words[swapPossition] = word;

            //}

            //Console.WriteLine(string.Join("\n", words));




        }
    }
}
