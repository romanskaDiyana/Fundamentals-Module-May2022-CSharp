using System;
using System.Collections.Generic;

namespace _03Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //03. Orders
            //Create a program that keeps the information about products and their prices.
            //Each product has a name, a price and a quantity. If the product doesn't exist
            //yet, add it with its starting quantity.
            //If you receive a product, which already exists, increase its quantity by the
            //input quantity and if its price is different, replace the price as well.
            //You will receive products' names, prices and quantities on new lines.
            //Until you receive the command "buy", keep adding items. 

            //When you do receive the command "buy", print the items with
            //their names and the total price of all the products with that name.
            //Input
            //    • Until you receive "buy", the products will be coming in the format:
            //    "{name} {price} {quantity}".
            //    • The product data is always delimited by a single space.
            //Output
            //    • Print information about each product in the following format:
            //            "{productName} -> {totalPrice}"
            //    • Format the average grade to the 2nd digit after the decimal separator.


            Dictionary <string, double> orders = new Dictionary<string, double> ();
            Dictionary<string, int> newOrders = new Dictionary<string, int> ();  

            string input = Console.ReadLine ();

            while (input != "buy")
            {
                string[] command = input.Split();

                string productName = command [0];
                double productPrice = double.Parse(command[1]);
                int quantity = int.Parse(command[2]);

                if (!orders.ContainsKey(productName))
                {
                    orders.Add(productName, productPrice);
                    newOrders.Add(productName, quantity);
                }
                else if (orders.ContainsKey(productName))
                {
                    orders.Remove(productName);
                    orders.Add(productName, productPrice);
                    newOrders[productName] += quantity;
                }

                input = Console.ReadLine ();
            }

            foreach (var order in orders)
            {
                foreach (var newOrder in newOrders)
                {
                    if (order.Key == newOrder.Key)
                    {
                        Console.WriteLine($"{order.Key} -> {order.Value * newOrder.Value:f2}");
                    }
                }
            }
        }
    }
}
