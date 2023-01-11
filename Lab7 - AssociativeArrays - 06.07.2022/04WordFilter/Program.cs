using System;
using System.Linq;

namespace _04WordFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //04. Word Filter
            //Read an array of strings and take only words, whose length
            //is an even number. Print each word on a new line.

            //string[] strings = Console.ReadLine().Split().Where(w => w.Length %2 == 0).ToArray();

            //Console.WriteLine(string.Join("\n", strings));


            Console.WriteLine(string.Join("\n", Console.ReadLine()
                .Split()
                .Where(w => w.Length % 2 == 0)
                .ToArray()));
        }
    }
}
