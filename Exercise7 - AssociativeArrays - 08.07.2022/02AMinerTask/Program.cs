using System;
using System.Collections.Generic;

namespace _02AMinerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //02.Miner Task 
            //You will be given a sequence of strings, each on a new line.
            //Every odd line on the console is representing a resource
            //(e.g. Gold, Silver, Copper and so on) and every even - quantity.
            //Your task is to collect the resources and print them each on a new line.
            //Print the resources and their quantities in the following format:
            //"{resource} –> {quantity}"
            //The quantities will be in the range[1… 2 000000000].

            Dictionary<string,int> items = new Dictionary<string, int>();

            string resources = Console.ReadLine();

            while (resources != "stop")
            {
                if (resources == null) continue;
           
                int quantity = int.Parse(Console.ReadLine());

                if (!items.ContainsKey(resources))
                {
                    items.Add(resources, 0);
                }

                items[resources] += quantity;

                resources = Console.ReadLine();
            }

            foreach (var currentResources in items)
            {
                Console.WriteLine($"{currentResources.Key} -> {currentResources.Value}");
            }

        }
    }
}
