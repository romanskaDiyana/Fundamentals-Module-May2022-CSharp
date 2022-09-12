using System;

namespace _05Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //05. Orders 
            //Create a program that calculates and prints the total price of an order.
            //The method should receive two parameters:
            //    • A string, representing a product -"coffee",  "water", "coke", "snacks"
            //    • An integer, representing the quantity of the product
            //The prices for a single item of each product are:
            //    • coffee – 1.50
            //    • water – 1.00
            //    • coke – 1.40
            //    • snacks – 2.00
            //Print the result, rounded to the second decimal place.

            string typeOfProduct = Console.ReadLine();
            int quantityOfProduct = int.Parse(Console.ReadLine());

            double totalPrice = 0;

            TotalPriceOfProducts(typeOfProduct, quantityOfProduct, totalPrice);

            static void TotalPriceOfProducts(string typeOfProduct,int quantityOfProduct,double totalPrice)

            { if (typeOfProduct == "coffee")
                {
                    totalPrice = quantityOfProduct * 1.50;
                }
                else if (typeOfProduct == "water")
                {
                    totalPrice = quantityOfProduct * 1.00;
                }
                else if (typeOfProduct == "coke")
                {
                    totalPrice = quantityOfProduct * 1.40;
                }
                else if (typeOfProduct == "snacks")
                {
                    totalPrice = quantityOfProduct * 2.00;
                }

                Console.WriteLine($"{totalPrice:f2}");
            }
        }
    }
}
