using System;

namespace _07TheatrePromotion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //07.Theatre Promotions 
            //A theatre sails tickets at discount and a program is needed to
            //calculate the price of a single ticket. If the given age does
            //not fit one of the categories, you should print "Error!".  
            //Input
            //The input comes in two lines. On the first line you
            //will receive the type of day.On the second – the age of the person.
            //Output
            //Print the price of the ticket according to the table or "Error!",
            //if the age is not in the table.
            //Constraints
            //    • The age will be in the interval[-1000…1000].
            //    • The type of day will always be valid. 


            string dayOfWeek = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            if (dayOfWeek == "Weekday" || dayOfWeek == "Weekend" || dayOfWeek == "Holiday")
            {
                if (age > 122 || age < 0)
                {
                    Console.WriteLine("Error!");
                    return;
                }
            }

            int priceOfTicket = 0;

            if (dayOfWeek == "Weekday")
            {
                if (age <= 122 & age > 64)
                {
                    priceOfTicket = 12;
                }
                else if (age <= 64 & age > 18)
                {
                    priceOfTicket = 18;
                }
                else if (age >= 0 & age <= 18)
                {
                    priceOfTicket = 12;
                }
            }
            else if (dayOfWeek == "Weekend")
            {
                if (age <= 122 & age > 64)
                {
                    priceOfTicket = 15;
                }
                else if (age <= 64 & age > 18)
                {
                    priceOfTicket = 20;
                }
                else if (age >= 0 & age <= 18)
                {
                    priceOfTicket = 15;
                }
            }
            else if (dayOfWeek == "Holiday")
            {
                if (age <= 122 & age > 64)
                {
                    priceOfTicket = 10;
                }
                else if (age <= 64 & age > 18)
                {
                    priceOfTicket = 12;
                }
                else if (age >= 0 & age <= 18)
                {
                    priceOfTicket = 5;
                }
            }

            Console.WriteLine(priceOfTicket + "$");
        }
    }
}
