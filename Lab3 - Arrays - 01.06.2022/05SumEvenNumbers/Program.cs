using System;
using System.Linq;

namespace _05SumEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //05. Sum Even Numbers
            //Read an array from the console and sum only its even values. 

            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).Where(x => x % 2 == 0).ToArray();

            int sumOfEvenNumbers = 0;

            foreach (int number in numbers)
            {
                sumOfEvenNumbers += number;
            }

            Console.WriteLine(sumOfEvenNumbers);
        }
    }
}
