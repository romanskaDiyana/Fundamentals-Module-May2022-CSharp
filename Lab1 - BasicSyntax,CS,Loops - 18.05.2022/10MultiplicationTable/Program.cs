using System;

namespace _10MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //10. Multiplication Table
            //Create a program that receives an integer as an input.
            //Print the 10 times table for this integer. See the examples below for more information.
            //        Output
            //        Print every row of the table in the following format:
            //        { theInteger}
            //        X { times} = { product}
            //        Constraints
            //• The integer will be in the interval[1…100]


            int number = int.Parse(Console.ReadLine());

            MultiplicationTable(number);
        }

        static void MultiplicationTable(int number)
        {
            int from = 1;
            int to = 10;

            for (int i = from; i <= 10; i++)
            {
                int result = number * i;

                Console.WriteLine($" {number} X {i} = {result}");
            }
        }
    }
}
