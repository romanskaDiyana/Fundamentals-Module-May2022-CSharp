using System;

namespace _01Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //01. Train
            //A train has n number of wagons (integer, received as input). On the next n lines, you will receive the number of people that are going to get on each wagon. Print out the number of passengers in each wagon followed by the total number of passengers on the train.

            int numberOfWagons = int.Parse(Console.ReadLine());

            int[] eachWagon = new int[numberOfWagons];

            int totalSumOfPassangers = 0;

            for (int i = 0; i < eachWagon.Length; i++)
            {
                eachWagon[i] = int.Parse(Console.ReadLine());
                totalSumOfPassangers += eachWagon[i];
            }

            foreach (var wagon in eachWagon)
            {
                Console.Write(wagon + " ");
            }

            Console.WriteLine();
            Console.WriteLine(totalSumOfPassangers);
        }
    }
}
