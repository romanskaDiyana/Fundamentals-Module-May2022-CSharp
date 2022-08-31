using System;

namespace _10LowerOrUpper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //10. Lower or Upper
            //Create a program that prints whether a given character is upper-case or lower case.

            char digit = char.Parse(Console.ReadLine());

            if (char.IsLower(digit))
            {
                Console.WriteLine("lower-case");
            }
            else
            {
                Console.WriteLine("upper-case");
            }
        }
    }
}
