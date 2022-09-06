using System;
using System.Linq;

namespace _04ArrayRotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //04.Array Rotation
            //Create a program that receives an array and several rotations that you have to perform. The rotations are done by moving the first element of the array from the front to the back. Print the resulting array.

            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int numberOfRotations = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfRotations; i++)
            {
                int swappedElement = numbers[0];

                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    numbers[j] = numbers[j + 1];
                }

                numbers[numbers.Length - 1] = swappedElement;

            }

            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
