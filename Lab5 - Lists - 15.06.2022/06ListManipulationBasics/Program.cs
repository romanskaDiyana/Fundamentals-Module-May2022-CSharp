using System;
using System.Collections.Generic;
using System.Linq;

namespace _06ListManipulationBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //06.List Manipulation Basics
            //Create a program that reads a list of integers.
            //Then until you receive "end", you will receive different commands:
            //    • Add { number}: add a number to the end of the list.
            //    • Remove { number}: remove a number from the list.
            //    • RemoveAt { index}: remove a number at a given index.
            //    • Insert { number}
            //            { index}: insert a number at a given index.
            //Note: All the indices will be valid!
            //When you receive the "end" command, print the final state of the list(separated by spaces).

            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = "";
            
                for (int i = 0; i < list.Count; i++)
                {
                    command = Console.ReadLine();
                    while (command !="end")
                    {
                        list.Add(int.Parse(Console.ReadLine()));
                        list.Remove(int.Parse(Console.ReadLine()));
                        list.RemoveAt(int.Parse(Console.ReadLine()));
                        list.Insert(int.Parse(Console.ReadLine()), i);
                    }
                   
                }

            Console.WriteLine(String.Join(" ", list));
              
        }
    }
}
