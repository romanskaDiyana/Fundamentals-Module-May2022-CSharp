using System;
using System.Data;

namespace _03GamingStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //03. Gaming Store
            //Create a program, which helps you buy the games. The valid games are the following games in this table:

            double balance = double.Parse(Console.ReadLine());

            string gameName = Console.ReadLine();
            double pricePerGame = 0;
            double totalPrice = 0;
            while (gameName != "Game Time")
            {
                if (gameName == "OutFall 4") pricePerGame = 39.99;
                else if (gameName == "CS: OG") pricePerGame = 15.99;
                else if (gameName == "Zplinter Zell") pricePerGame = 19.99;
                else if (gameName == "Honored 2") pricePerGame = 59.99;
                else if (gameName == "RoverWatch") pricePerGame = 29.99;
                else if (gameName == "RoverWatch Origins Edition") pricePerGame = 39.99;
                else
                {
                    Console.WriteLine("Not Found");
                    gameName = Console.ReadLine();
                    continue;
                }

                if (balance < pricePerGame)
                {
                    Console.WriteLine("Too Expensive");
                    gameName = Console.ReadLine();
                    continue;
                }

                Console.WriteLine($"Bought {gameName}");
                gameName = Console.ReadLine();

                balance -= pricePerGame;
                totalPrice += pricePerGame;

                if (balance <= 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }

            }

            Console.WriteLine($"Total spent: ${totalPrice:f2}. Remaining: ${balance:f2}");
        }
    }
}
