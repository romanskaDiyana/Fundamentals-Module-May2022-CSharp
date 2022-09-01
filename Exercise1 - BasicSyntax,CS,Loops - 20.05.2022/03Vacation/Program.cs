using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace _03Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //03. Vacation
            //You will receive three lines from the console:
            //    • A count of people who are going on vacation.
            //    • Type of the group(Students, Business or Regular).
            //    • The day of the week which the group will stay on(Friday, Saturday or Sunday).
            //Based on the given information calculate how much the group will pay for the entire vacation.
            //The price for a single person is as follows: table*
            //There are also discounts based on some conditions:
            //    • For Students – if the group is 30 or more people, you should reduce the total price by 15 %.
            //    • For Business – if the group is 100 or more people, 10 of the people stay for free.
            //    • For Regular – if the group is between 10 and 20  people(both inclusively), reduce the total price by 5 %.
            //Note: You should reduce the prices in that EXACT order!
            //As an output print the final price which the group is going to pay in the format: 
            //"Total price: {price}"
            //The price should be formatted to the second decimal point.

            double countOfPeople = double.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();

            List<double> fridayPrices = new List<double>() { 8.45, 10.90, 15 };
            List<double> saturdayPrices = new List<double>() { 9.80, 15.60, 20 };
            List<double> sundayPrices = new List<double>() { 10.46, 16, 22.50 };

            double totalPrice = 0;

            switch (typeOfGroup)
            {
                case "Students":
                    Students(countOfPeople, typeOfGroup, dayOfWeek, totalPrice, fridayPrices, saturdayPrices, sundayPrices);
                    break;

                case "Business":
                    Business(countOfPeople, typeOfGroup, dayOfWeek, totalPrice, fridayPrices, saturdayPrices, sundayPrices);                  
                    break;

                case "Regular":
                   Regular(countOfPeople, typeOfGroup, dayOfWeek, totalPrice, fridayPrices, saturdayPrices, sundayPrices);
                    break;               
            }
        }

        static void Students(double countOfPeople, string typeOfGroup, string dayOfWeek, double totalPrice, List<double> fridayPrices, List<double> saturdayPrices, List<double> sundayPrices)
        {

            if (dayOfWeek == "Friday")
            {
                totalPrice = fridayPrices[0] * countOfPeople;
            }
            else if (dayOfWeek == "Saturday")
            {
                totalPrice = saturdayPrices[0] * countOfPeople;
            }
            else if (dayOfWeek == "Sunday")
            {
                totalPrice = sundayPrices[0] * countOfPeople;
            }

            if (countOfPeople >= 30)
            {
                totalPrice -= totalPrice * 0.15;
            }

            Console.WriteLine($"{totalPrice:f2}");
        }
        
        static void Business(double countOfPeople, string typeOfGroup, string dayOfWeek, double totalPrice, List<double> fridayPrices, List<double> saturdayPrices, List<double> sundayPrices)
        {
            if (dayOfWeek == "Friday")
            {
                totalPrice = fridayPrices[1] * countOfPeople;
            }
            else if (dayOfWeek == "Saturday")
            {
                totalPrice = saturdayPrices[1] * countOfPeople;
            }
            else if (dayOfWeek == "Sunday")
            {
                totalPrice = sundayPrices[1] * countOfPeople;
            }

            if (countOfPeople >= 100)
            {
                double currentPriceForOne = totalPrice / countOfPeople;
                double priceForFree = currentPriceForOne * 10;
                totalPrice -= priceForFree;
            }

            Console.WriteLine($"{totalPrice:f2}");
        }
        
        static void Regular(double countOfPeople, string typeOfGroup, string dayOfWeek, double totalPrice, List<double> fridayPrices, List<double> saturdayPrices, List<double> sundayPrices)
        {
            if (dayOfWeek == "Friday")
            {
                totalPrice = fridayPrices[2] * countOfPeople;
            }
            else if (dayOfWeek == "Saturday")
            {
                totalPrice = saturdayPrices[2] * countOfPeople;
            }
            else if (dayOfWeek == "Sunday")
            {
                totalPrice = sundayPrices[2] * countOfPeople;
            }

            if (countOfPeople >= 10 && countOfPeople <= 20)
            {
                totalPrice -= totalPrice * 0.05;
            }

            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
