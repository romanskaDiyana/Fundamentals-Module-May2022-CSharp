using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //01. Furniture
            //Create a program to calculate the total cost of different types of furniture. You will be given some lines of input, until you receive the line "Purchase". For the line to be valid it should be in the following format:
            //            ">>{furniture name}<<{price}!{quantity}"
            //The price can be a floating-point number or a whole number.Store the names of the furniture and the      total        price. At the end, print each bought furniture on a separate line in the format:
            //"Bought furniture:
            //{ 1st name}
            //            { 2nd name}
            //…"
            //And on the last line, print the following: "Total money spend: {spend money}", formatted to the   second         decimal   point..


            string regex = @">>(?<furnitureType>[A-Za-z\s]+)<<(?<price>\d+(.\d+)?)!(?<quantity>\d+)";          

            var totalFurnitureTypes = new List<string>();
            double totalPrice = 0;

            string input = Console.ReadLine();
            while (input!= "Purchase")
            {
                Match match = Regex.Match(input, regex,RegexOptions.IgnoreCase);

                if (match.Success)
                {
                    var furnitureType = match.Groups["furnitureType"].Value;

                    totalFurnitureTypes.Add(furnitureType);

                    var pricePerFurniture = double.Parse(match.Groups["price"].Value);
                    var quantity = int.Parse(match.Groups["quantity"].Value);

                    totalPrice += pricePerFurniture * quantity;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Bought furniture: ");
            totalFurnitureTypes.ForEach(Console.WriteLine);
            Console.WriteLine($"Total money spend: {totalPrice:f2}");
        }
    }
}
