using System;

namespace _02PoundsToDollars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Pounds to Dollars
            //Create a program that converts British pounds to US dollars formatted to the 3rd decimal point.

            decimal pounds = decimal.Parse(Console.ReadLine());

            decimal dollars = (decimal)1.31;

            decimal poundsToDollars = pounds * dollars;

            Console.WriteLine($"{poundsToDollars:f3}");
        }
    }
}
