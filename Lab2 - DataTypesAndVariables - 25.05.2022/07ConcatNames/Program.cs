using System;
using System.Runtime.InteropServices;

namespace _07ConcatNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //07. Concat Names
            //Read two names and a delimiter. Print the names joined by the delimiter.

            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            string concat = Console.ReadLine();

            Console.WriteLine($"{firstName}{concat}{lastName}");
        }
    }
}
