using System;

namespace _04PrintingTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //04. Printing Triangle
            //Create a method for printing triangles as shown below:

            PrintTriangle(int.Parse(Console.ReadLine()));

            static void PrintTriangle(int sizeOfTriangle)

            {
                for (int i = 1; i <= sizeOfTriangle; i++)
                {
                    PrintTriangleLine(i);
                }

                for (int i = sizeOfTriangle - 1 ; i > 0; i--)
                {
                    PrintTriangleLine(i);
                }
            }

            static void PrintTriangleLine(int line) 
            {
                for (int i = 1; i <= line ; i++)
                {
                    Console.Write($"{i} ");
                }

                Console.WriteLine();
            }
        }
    }
}
