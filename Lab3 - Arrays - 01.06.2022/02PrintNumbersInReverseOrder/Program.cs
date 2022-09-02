using System;
using System.Linq;

namespace _02PrintNumbersInReverseOrder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //02. Print Numbers in Reverse Order
            //Read n numbers and print them in reverse order, separated by a single space.

            int numberOfNumbers = int.Parse(Console.ReadLine());
            var array = new int[numberOfNumbers];

            for (int i = 0; i < numberOfNumbers; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            var newArray = new int[array.Length];

            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = array[array.Length - 1 - i];
            }
      
            foreach (var number in newArray)
            {
                Console.Write(number + " ");
            }

            //Array.Sort(array);
            //Array.Reverse(array);

            //foreach (var number in array)
            //{
            //    Console.Write(number + " ");
            //}
        }
    }
}
