using System;

namespace _03Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //03.Calculations
            //Create a program that receives three lines of input:
            //    • On the first line – a string – "add", "multiply", "subtract", "divide".
            //    • On the second line – a number.
            //    • On the third line – another number.
            //You should create four methods(for each calculation) and
            //invoke the corresponding method depending on the command.
            //The method should also print the result(needs to be void).

            string typeOfCalculation = Console.ReadLine();
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());


            if (typeOfCalculation == "add")
            {
                AddNumbers(firstNumber, secondNumber);
            }
            else if (typeOfCalculation == "multiply")
            {
                MultiplyNumbers(firstNumber, secondNumber);
            }
            else if (typeOfCalculation == "subtract")
            {
                SubtractNumbers(firstNumber, secondNumber);
            }
            else if (typeOfCalculation == "divide")
            {
                DivideNumbers(firstNumber, secondNumber);
            }
        }
            static void AddNumbers(int firstNumber,int secondNumber) 
            {
                Console.WriteLine(firstNumber + secondNumber);
            }

            static void MultiplyNumbers(int firstNumber, int secondNumber)
            {
                Console.WriteLine(firstNumber * secondNumber);
            }

            static void SubtractNumbers(int firstNumber, int secondNumber)
            {
                Console.WriteLine(firstNumber - secondNumber);
            }

            static void DivideNumbers(int firstNumber, int secondNumber)
            {
                Console.WriteLine(firstNumber / secondNumber);
            }
    }
}
