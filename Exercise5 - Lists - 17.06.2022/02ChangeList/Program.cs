using System;
using System.Linq;

namespace _02ChangeList
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //02. Change List
            //Create a program, that reads a list of integers from the console and receives commands to manipulate the list.
            //            Your program may receive the following commands:
            //    • Delete { element} – delete all elements in the array, which are equal to the given element.
            //    • Insert { element}
            //            { position} – insert the element at the given position.
            //You should exit the program when you receive the "end" command.Print all numbers in the array, separated by a single whitespace.

            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string line = Console.ReadLine();

            while (line != "end")
            {
                string[] tokens = line.Split();
                string cmd = tokens[0];
                if (cmd == "Delete")
                {
                    int element = int.Parse(tokens[1]);
                    numbers.RemoveAll(el => el == element);
                }
                else if (cmd == "Insert")
                {
                    int element = int.Parse(tokens[1]);
                    int index = int.Parse(tokens[2]);
                    numbers.Insert(index, element);
                }
                line = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
