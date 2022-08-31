using System;

namespace _01ConvertMetersToKilometers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //01. Convert Meters to Kilometers
            //You will be given an integer that will be a distance in meters. Create a program that converts meters to kilometers formatted to the second decimal point.

            float meters = float.Parse(Console.ReadLine());

            double kilometers = meters / 1000;

            Console.WriteLine($"{kilometers:f2}");
        }
    }
}
