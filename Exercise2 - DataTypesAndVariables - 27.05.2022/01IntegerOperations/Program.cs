using System;
using System.ComponentModel;

namespace _01IntegerOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //01. Integer Operations
            //Create a program that receives four integer numbers.
            //            You should perform the following operations:
            //    • Add first to the second.
            //    • Divide(integer) the result of the first operation by the third number.
            //    • Multiply the result of the second operation by the fourth number.
            //Print the result after the last operation.

            int[] numbers = new int[4];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(OperationsWithNumbers(numbers));          
        }

        static int OperationsWithNumbers(int[] numbers)
        {
            int addNumbers = numbers[0] + numbers[1];
            int divideNumbers = addNumbers / numbers[2];
            int multiplyNumbers = divideNumbers * numbers[3];

            return multiplyNumbers;
        }
    }
}
