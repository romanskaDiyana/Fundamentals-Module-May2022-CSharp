using System;
using static System.Net.Mime.MediaTypeNames;
using System.Collections.Generic;

namespace _07WaterOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //7. Water Overflow
            //You have a water tank with a capacity of 255 liters.On the next n lines, you will receive liters of water, which you have to pour into your tank.If the capacity is not enough, print "Insufficient capacity!" and continue reading the next line. On the last line, print the liters in the tank.

            int capacity = 255;
            int littersInTheTank = 0;

            int numberOfPours = int.Parse(Console.ReadLine());
           

            for (int i = 0; i < numberOfPours; i++)
            {
                int litters = int.Parse(Console.ReadLine());

                if (capacity < litters)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    capacity -= litters;
                    littersInTheTank += litters;
                }
            }   
            
            Console.WriteLine(littersInTheTank);         
        }
    }
}
