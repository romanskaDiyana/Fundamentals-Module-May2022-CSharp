using System;
using System.Linq;

namespace _06EvenAndOddSubtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //06. Even and Odd Subtraction
            //Create a program that calculates the difference between the sum of the even and the sum of the odd numbers in an array.

            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] oddNumbers = numbers.Where(x => x % 2 != 0).ToArray();
            int[] evenNumbers = numbers.Where(x => x % 2 == 0).ToArray();
            
            int result = evenNumbers.Sum(x => x) - oddNumbers.Sum(x => x);  

            Console.WriteLine(result);
        }
    }
}
