using System;

namespace _05AddAndSubstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //05.Add and Subtract
            //You will receive 3 integers. Create a method that returns the sum of
            //the first two integers and another method that subtracts the third
            //integer from the result of the sum method.


            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int addedResult = AddFirstAndSecondNumber(firstNumber, secondNumber);

            int substractAddedResult = SubstractAddedToThird(addedResult, thirdNumber);

            PrintFinalResult(substractAddedResult);

        }
        static int AddFirstAndSecondNumber(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        static int SubstractAddedToThird(int addedResult, int thirdNumber)
        {
            return addedResult - thirdNumber;
        }
        
        static void PrintFinalResult(int substractAddedResult)
        {
            Console.WriteLine(substractAddedResult);
        }
    }
}
