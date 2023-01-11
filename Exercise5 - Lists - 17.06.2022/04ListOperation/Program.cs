using System;
using System.Linq;

namespace _04ListOperation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //04.List Operation
            //The first input line will hold a list of integers. Until we receive the "End" command, we will be given operations we have to apply to the list.
            //            The possible commands are:
            //    • Add { number} – add the given number to the end of the list
            //    • Insert { number}
            //            { index} – insert the number at the given index
            //    • Remove { index} – remove the number at the given index
            //    • Shift left { count} – first number becomes last. This has
            //    to be repeated the specified number of times
            //    • Shift right { count} – last number becomes first. To be
            //    repeated the specified number of times
            //Note: the index given may be outside of the bounds of the array.
            //In that case print: "Invalid index".


            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] tokens = command.Split();

                if (tokens[0] == "Add")
                {
                    int number = int.Parse(tokens[1]);
                    numbers.Add(number);
                }
                else if (tokens[0] == "Insert")
                {
                    int number = int.Parse(tokens[1]);
                    int index = int.Parse(tokens[2]);
                    if (index > numbers.Count - 1 || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    numbers.Insert(index, number);
                }
                else if (tokens[0] == "Remove")
                {
                    int index = int.Parse(tokens[1]);
                    if (index > numbers.Count - 1 || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    numbers.RemoveAt(index);
                }
                else if (tokens[0] == "Shift")
                {
                    int count = int.Parse(tokens[2]);
                    if (tokens[1] == "left")
                    {
                        for (int i = 0; i < count; i++)
                        {
                            numbers.Add(numbers[0]);
                            numbers.RemoveAt(0);
                        }
                    }
                    else if (tokens[1] == "right")
                    {
                        for (int i = 0; i < count; i++)
                        {
                            numbers.Insert(0, numbers[numbers.Count - 1]);
                            numbers.RemoveAt(numbers.Count - 1);
                        }
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));

        }
    }
}
