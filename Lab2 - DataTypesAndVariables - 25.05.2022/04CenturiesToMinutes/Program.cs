using System;

namespace _04CenturiesToMinutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //04. Centuries to Minutes
            //Create a program to enter an integer number of centuries and convert it to years, days, hours, and minutes.

            byte centuries = byte.Parse(Console.ReadLine());

            int years = centuries * 100;
            int days = (int)(years * 365.2422);
            int hours = days * 24;
            int minutes = hours * 60;       
             
            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
        }
    }
}
