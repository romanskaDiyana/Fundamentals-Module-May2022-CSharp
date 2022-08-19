using System;

namespace _08DivisibleBy3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //08. Divisible By 3
            //Create a program, which prints all the numbers from 1 to 100,
            //that are divisible by 3. You have to use a single for loop. The program should not receive input.

            for (int i = 3; i <= 99; i+=3)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
