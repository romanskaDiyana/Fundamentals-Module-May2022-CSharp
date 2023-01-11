using System;
using System.Text.RegularExpressions;

namespace _03SoftUniBarIncome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //03. SoftUni Bar Income
            //Let's take a break and visit the game bar at SoftUni. It is about time for the people behind the bar to go home and you are the person who has to draw the line and calculate the money from the products that were sold throughout the day. Until you receive a line with the text "end of shift", you will be given lines of input. But before processing that line, you have to do some validations first.
            //            Each valid order should have a customer, product, count and a price:
            //    • A valid customer's name should be surrounded by ' % ' and must start with a capital letter, followed by lower-case letters.
            //    • A valid product contains any word character and must be surrounded by '<' and '>'.
            //    • A valid count is an integer, surrounded by '|'.
            //    • A valid price is any real number followed by '$'.
            //The parts of a valid order should appear in the order given: customer, product, count and price.
            //Between each part there can be other symbols, except '|', '$', '%' and '.'.
            //For each valid line, print on the console: "{customerName}: {product} - {totalPrice}".
            //When you receive "end of shift" print the total amount of money for the day, rounded to 2 decimal places in the following format: "Total income: {income}".
            //Input / Constraints
            //    • Strings that you have to process until you receive text "end of shift".
            //Output
            //    • Print all of the valid lines in the format "{customerName}: {product} - {totalPrice}".
            //    • After receiving "end of shift", print the total amount of money for the day, rounded to 2 decimal places in the following format: "Total income: {income}".
            //    • Allowed working time / memory: 100ms / 16MB.



            Regex regex = new Regex(@"%(?<customer>[A-Z][a-z]+)%[^|$%.]*<(?<product>\w+)>[^|$%.]*\|(?<quantity>[\d]+)\|[^|$%.]*?(?<price>[\d(.\d)]+)\$");


            string input = Console.ReadLine();
            double totalPriceForCurrentProduct = 0;
            double totalIncome = 0;

            while (input != "end of shift")
            {
                bool isValid = regex.IsMatch(input);
                if (isValid)
                {
                    string customer = regex.Match(input).Groups["customer"].Value;
                    string product = regex.Match(input).Groups["product"].Value;
                    int quantity = int.Parse(regex.Match(input).Groups["quantity"].Value);
                    double price = double.Parse(regex.Match(input).Groups["price"].Value);

                    totalPriceForCurrentProduct = price * quantity;
                    totalIncome += totalPriceForCurrentProduct;

                    Console.WriteLine($"{customer}: {product} - {totalPriceForCurrentProduct:f2}");
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
}
