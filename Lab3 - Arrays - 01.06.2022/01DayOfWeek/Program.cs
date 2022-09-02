using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01DayOfWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Day of Week
            //Enter a number in range 1 - 7 and print out the word representing it or "Invalid Day!".Use an array of strings.

            Dictionary<int, string> dayOfWeek = new Dictionary<int, string>();
            DayOfWeek(dayOfWeek);

            int number = int.Parse(Console.ReadLine());

            if (number < 1 || number > 7)
            {
                Console.WriteLine("Invalid day!");
                return;
            }
            foreach (var day in dayOfWeek)
            {
                if (number == day.Key)
                {
                    Console.WriteLine(day.Value);
                }
            }
        }

        static void DayOfWeek(Dictionary<int, string> dayOfWeek)
        {
            dayOfWeek.Add(1, "Monday");
            dayOfWeek.Add(2, "Tuesday");
            dayOfWeek.Add(3, "Wednesday");
            dayOfWeek.Add(4, "Thursday");
            dayOfWeek.Add(5, "Friday");
            dayOfWeek.Add(6, "Saturday");
            dayOfWeek.Add(7, "Sunday");
        }
    }
}
