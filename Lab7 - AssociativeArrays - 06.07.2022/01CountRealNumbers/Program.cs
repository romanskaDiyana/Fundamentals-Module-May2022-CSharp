using System;
using System.Collections.Generic;
using System.Linq;

namespace _01CountRealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //01.Count Real Numbers
            //Read a list of integers and print them in ascending order,
            //along with their number of occurrences.

            List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();

            SortedDictionary<double, int> occurrencesTimes = new SortedDictionary<double, int>();   

            for (int i = 0; i < numbers.Count; i++)
            {
                if (!occurrencesTimes.ContainsKey(numbers[i]))
                {
                    occurrencesTimes.Add(numbers[i], 0);
                }

                occurrencesTimes[numbers[i]]++;
            }

            foreach (KeyValuePair<double, int> occurrence in occurrencesTimes)
                Console.WriteLine($"{occurrence.Key} -> {occurrence.Value}");

        }
    }
}
