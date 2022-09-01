using System;
using System.Linq;

namespace _02NameLastDigit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //02. English name of The Last Digit
            //Create a method that returns the English spelling of the last digit of a given number. Write a program that reads an integer and prints the returned value from this method.

            char[] number = Console.ReadLine().ToCharArray();
            string lastDigit = number[number.Length - 1].ToString();          

            EnglishNameOfTheLastDigit(lastDigit);
        }
        static void EnglishNameOfTheLastDigit(string lastDigit)
        {
            if (lastDigit == "0") Console.WriteLine("zero");
            else if (lastDigit == "1") Console.WriteLine("one");
            else if (lastDigit == "2") Console.WriteLine("two");
            else if (lastDigit == "3") Console.WriteLine("three");
            else if (lastDigit == "4") Console.WriteLine("four");
            else if (lastDigit == "5") Console.WriteLine("five");
            else if (lastDigit == "6") Console.WriteLine("six");
            else if (lastDigit == "7") Console.WriteLine("seven");
            else if (lastDigit == "8") Console.WriteLine("eight");
            else if (lastDigit == "9") Console.WriteLine("nine");
        }
    }
}
