using System;

namespace _07MaxSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //07. Max Sequence of Equal Elements
            //Create a program that finds the longest sequence of equal elements in an array of integers. If several equal sequences are present in the array, print out the leftmost one.

            string[] array = Console.ReadLine().Split();

            string maxSequence = "";
            int count = 0;
            int currentCount = 0;

            for (int i = 0; i < array.Length - 1; i++)
            {

                if (array[i] == array[i + 1])
                {
                    currentCount++;
                    if (currentCount > count)
                    {
                        count = currentCount;
                        maxSequence = array[i];
                    }
                }
                else
                {
                    currentCount = 0;
                }

            }
            for (int j = 0; j <= count; j++)
            {
                Console.Write(maxSequence + " ");
            }
        }
    }
}
