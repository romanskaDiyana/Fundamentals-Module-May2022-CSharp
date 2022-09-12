using System;

namespace _07NxNMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //07. NxN Matrix
            //Create a method that receives a single integer n and
            //prints an NxN matrix using this number as a filler.

            int input = int.Parse(Console.ReadLine());

            MatrixCreator(input);
        }

        static void MatrixCreator(int input)
        {
            for (int rows = 0; rows < input; rows++)
            {
                for (int columns = 0; columns < input; columns++)
                {
                    Console.Write(input + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}
