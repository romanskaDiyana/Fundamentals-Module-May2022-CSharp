using System;

namespace _11MultiplicationTable2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //11. Multiplication Table 2.0
            //Rewrite the program from the previous task so it can receive the multiplier from the console.
            //Print the table with the multiplier in the interval from the given number to 10.
            //If the given multiplier is more than 10, print only one row with the integer,
            //the given multiplier, and the product. See the examples below for more information.
            //        Output
            //        Print every row of the table in the following format:
            //        { theInteger}
            //        X { times} = { product}
            //        Constraints
            //• The integer will be in the interval[1…100]

            int number = int.Parse(Console.ReadLine());
            int from = int.Parse(Console.ReadLine());

            MultiplicationTable(number, from);
        }

        static void MultiplicationTable(int number, int from)
        {
            int to = 10;

            do
            {
                Console.WriteLine($"{number} X {from} = {number * from}");
                from++;
            } while (from <= to);
        }
    }
}
