using System;
using System.Collections.Generic;
using System.Linq;

namespace _04ListofProducts
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //04.List of Products
            //Read a number n and n lines of products.
            //Print a numbered list of all the products ordered by name.
            
            int numberOfProducts = int.Parse(Console.ReadLine());

            List<string> products = new List<string>();

            static void SelectionSort(List<string> products)
            {
                for (int i = 0; i < products.Count; i++)
                {
                    int firstProductIndex = i;

                    for (int j = i + 1; j < products.Count; j++)
                    {
                        if (products[firstProductIndex].CompareTo(products[j]) > 0)
                        {
                            firstProductIndex = j;
                        }
                    }

                    string swappedElement = products[firstProductIndex];
                    products[firstProductIndex] = products[i];
                    products[i] = swappedElement;
                }
            }

            for (int i = 0; i < numberOfProducts; i++)
            {
                products.Add(Console.ReadLine());
            }

            SelectionSort(products);

            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{products[i]}");
            }
        }
    }
}
