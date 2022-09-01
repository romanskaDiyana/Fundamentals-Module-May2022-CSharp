using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;

namespace _08BeerKegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //08. Beer Kegs
            //Create a program, which calculates the volume of n beer kegs. You will receive in total 3 * n lines. Every three lines will hold information for a single keg. First up is the model of the keg, after that is the radius of the keg, and lastly is the height of the keg.
            //alculate the volume using the following formula: π* r^2 * h.
            //In the end, print the model of the biggest keg.

            Dictionary<string, double> kegDictionary = new Dictionary<string, double>();    
          
            int numberOfKegs = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfKegs; i++)
            {
               string model = Console.ReadLine();
               double radius = double.Parse(Console.ReadLine());
               double height = int.Parse(Console.ReadLine());

               double currentKegVolume = (Math.PI * Math.Pow(radius, 2) * height);
               kegDictionary.Add(model,currentKegVolume);
            }

            var maxValueKey = kegDictionary.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
            //var maxValueKey = kegDictionary.OrderByDescending(x => x.Value).First().Key;

            Console.WriteLine(maxValueKey);
        }
    }
}
