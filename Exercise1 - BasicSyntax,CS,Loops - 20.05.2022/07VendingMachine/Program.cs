using System;
using System.Data;
using System.Threading.Channels;

namespace _07VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //07. Vending Machine
            //Write a program that accumulates coins. Until the "Start" command is given, you will receive coins, and only the valid ones should be accumulated. Valid coins are:
            //• 0.1, 0.2, 0.5, 1, and 2
            //If an invalid coin is inserted, print "Cannot accept {money}" and continue to the next line.
            //    On the next lines, until the "End" command is given you will start receiving products, which a customer wants to buy.The vending machine has only:
            //    • "Nuts" with a price of 2.0
            //    • "Water" with a price of 0.7
            //    • "Crisps" with a price of 1.5
            //    • "Soda" with a price of 0.8
            //    • "Coke" with a price of 1.0
            //If the customer tries to purchase a not existing product print "Invalid product".
            //    When a customer has enough money to buy the selected product, print "Purchased {product name}", otherwise print "Sorry, not enough money", and continue to the next line.
            //    When the "End" command is given print the reminding balance, formatted to the second decimal point: "Change: {money left}".

            string command = Console.ReadLine();

            double totalCoins = 0;
            while (command != "Start")
            {
                double coins = double.Parse(command);
                if (coins == 2 || coins == 1 || coins == 0.5 || coins == 0.2 || coins == 0.1) totalCoins += coins;
                else Console.WriteLine($"Cannot accept {coins}");

                command = Console.ReadLine();
            }

            string productType = Console.ReadLine();
            double pricePerProduct = 0;

            while (productType != "End")
            {
                if (productType == "Nuts" || productType == "Water" || productType == "Crisps" || productType == "Soda" || productType == "Coke")
                {
                    switch (productType)
                    {
                        case "Nuts": pricePerProduct = 2.0; break;
                        case "Water": pricePerProduct = 0.70; break;
                        case "Crisps": pricePerProduct = 1.50; break;
                        case "Soda": pricePerProduct = 0.80; break;
                        case "Coke": pricePerProduct = 1.0; break;
                    }

                    if (totalCoins >= pricePerProduct)
                    {
                        Console.WriteLine($"Purchased {productType.ToLower()}");
                        totalCoins -= pricePerProduct;
                    }
                    else Console.WriteLine("Sorry, not enough money");
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }

                productType = Console.ReadLine();
            }

            Console.WriteLine($"Change: {totalCoins:f2}");
        }
    }
}
