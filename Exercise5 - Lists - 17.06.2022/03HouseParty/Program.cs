using System;
using System.Collections.Generic;

namespace _03HouseParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //03. House Party
            //Create a program that keeps track of the guests that are going to a house party.
            //On the first line, of input you are going to receive the number of commands that will follow.
            //            On the next lines, you are going to receive some of the following:  "{name} is going!"
            //    • You have to add the person, if they are not on the guestlist already.
            //    • If the person is on the list print the following to the console:
            //    "{name} is already in the list!"
            //"{name} is not going!"
            //    • You have to remove the person, if they are on the list. 
            //    • If not, print out: "{name} is not in the list!"
            //Finally, print all of the guests, each on a new line.

            int n = int.Parse(Console.ReadLine());
            var listOfNames = new List<string>();
            for (int i = 0; i < n; i++)
            {
                var command = Console.ReadLine().Split();
                string currName = command[0];
                if (listOfNames.Contains(currName) && command[2] == "going!")
                {
                    Console.WriteLine($"{currName} is already in the list!");
                }
                else if (listOfNames.Contains(currName) && command[2] == "not")
                {
                    listOfNames.Remove(currName);
                }
                else if (!listOfNames.Contains(currName) && command[2] == "not")
                {
                    Console.WriteLine($"{currName} is not in the list!");
                }
                else
                {
                    listOfNames.Add(currName);
                }
            }

            foreach (var currName in listOfNames)
            {
                Console.WriteLine(currName);
            }
        }
    }
}
