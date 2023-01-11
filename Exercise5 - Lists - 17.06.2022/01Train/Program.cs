using System;
using System.Collections.Generic;
using System.Linq;

namespace _01Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //01. Train
            //On the first line, we will receive a list of wagons (integers).
            //Each integer represents the number of passengers that are currently
            //in each wagon of the passenger train. On the next line, you will
            //receive the max capacity of a wagon, represented as a single integer.
            //Until you receive the "end" command, you will be receiving two types of input:
            //    • Add { passengers} – add a wagon to the end of the train
            //    with the given number of passengers.
            //    • { passengers} – find a single wagon to fit all the
            //    incoming passengers(starting from the first wagon).
            //In the end, print the final state of the train(all the wagons
            //separated by a space).

            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapacity = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] tokens = command.Split();
                if (tokens.Length == 2)
                {
                    int wagon = int.Parse(tokens[1]);
                    wagons.Add(wagon);
                }
                else
                {
                    int passangers = int.Parse(tokens[0]);
                    FindWagon(wagons, maxCapacity, passangers);
                }
                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", wagons));
        }

        private static void FindWagon(List<int> wagons, int maxCapacity, int passangers)
        {
            for (int i = 0; i < wagons.Count; i++)
            {
                int currentWagon = wagons[i];
                if (currentWagon + passangers <= maxCapacity)
                {
                    wagons[i] += passangers;
                    break;
                }
            }


        }
    }
}
