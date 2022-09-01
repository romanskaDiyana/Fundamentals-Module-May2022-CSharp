using System;

namespace _06TriplesOfLatinLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //6.Triples of Latin Letters
            //Create a program that receives an integer n and print all
            //triples of the first n small Latin letters, ordered alphabetically:


            int alphabeticRange = int.Parse(Console.ReadLine());

            for (int i = 0; i < alphabeticRange; i++)
            {
                for (int j = 0; j < alphabeticRange; j++)
                {
                    for (int g = 0; g < alphabeticRange; g++)
                    {
                        char firstChar = (char)('a' + i);
                        char secondChar = (char)('a' + j);
                        char thirdChar = (char)('a' + g);

                        Console.WriteLine($"{firstChar}{secondChar}{thirdChar}");

                    }
                }
            }

            //    int alphabeticRange = int.Parse(Console.ReadLine());

            //    for (char firstChar = 'a'; firstChar < 'a' + alphabeticRange; firstChar++)
            //    {
            //        for (char secondChar = 'a'; secondChar < 'a' + alphabeticRange; secondChar++)
            //        {
            //            for (char thirdChar = 'a'; thirdChar < 'a' + alphabeticRange; thirdChar++)
            //            {
            //                Console.WriteLine($"{firstChar}{secondChar}{thirdChar}");
            //            }
            //        }
            //    }
        }
    }
}
