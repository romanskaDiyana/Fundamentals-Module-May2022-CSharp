using System;
using System.Collections.Generic;
using System.Linq;

namespace _02Gauss__Trick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; i < list.Count / 2; i++)
            {
                int sum = list[i] + list[list.Count - 1 - i];

                Console.Write($"{sum} ");
            }

            if (list.Count % 2 == 1)
            {
                Console.WriteLine($"{list[list.Count / 2]}");
            }
        }
    }
}
