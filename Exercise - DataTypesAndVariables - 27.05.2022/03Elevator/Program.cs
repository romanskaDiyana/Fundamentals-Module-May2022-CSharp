using System;

namespace _03Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //03. Elevator
            //Calculate how many courses will be needed to elevate n persons by using an elevator of the capacity of p persons. The input holds two lines: the number of people n and the capacity p of the elevator.

            int numberOfPeople = int.Parse(Console.ReadLine());
            int capacityOfTheElevator = int.Parse(Console.ReadLine());

            double withReminderCourses = (double)numberOfPeople / capacityOfTheElevator;

            Console.WriteLine(Math.Ceiling(withReminderCourses));
        }
    }
}
