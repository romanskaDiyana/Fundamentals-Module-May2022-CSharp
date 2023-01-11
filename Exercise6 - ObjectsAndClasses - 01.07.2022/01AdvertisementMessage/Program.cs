﻿using System;

namespace _01AdvertisementMessage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //01.Advertisment Message
            //Create a program that generates random fake advertisement messages to advertise a product.
            //The messages must consist of 4 parts: phrase + event + author + city.
            //Use the following predefined parts:

            //    • Phrases –
            //    { "Excellent product.",
            //    "Such a great product.", "I always use that product.",
            //    "Best product of its category.", "Exceptional product.",
            //    "I can't live without this product."}

            //    • Events –
            //    { "Now I feel good.", "I have succeeded with this product.",
            //    "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.",
            //    "Try it yourself, I am very satisfied.", "I feel great!"}

            //    • Authors – { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"}

            //    • Cities – { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"}

            //The format of the output message is the following:
            //"{phrase} {event} {author} – {city}."
            //You will receive the number of messages to be generated.
            //Print each random message at a separate line.


            string[] phrases =

            {
                "Excellent product.", 
                "Such a great product.", 
                "I always use that product.", 
                "Best product of its category.", 
                "Exceptional product.",
                "I can't live without this product."
            };

            string[] events =
            {
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.", 
                "I feel great!"
            };

            string[] authors
                = 
            {   "Diana", 
                "Petya", 
                "Stella", 
                "Elena", 
                "Katya", 
                "Iva", 
                "Annie", 
                "Eva" 
            };

            string[] cities = 
            { 
                "Burgas", 
                "Sofia",
                "Plovdiv",
                "Varna", 
                "Ruse" 
            };

            int countOfMessagesToCreate = int.Parse(Console.ReadLine());

            Random random = new Random();

            for (int i = 0; i < countOfMessagesToCreate; i++)
            {
                string phrase = phrases[random.Next(0, phrases.Length)];
                string currEvent = events[random.Next(0, events.Length)];
                string author = authors[random.Next(0, authors.Length)];
                string city = cities[random.Next(0, cities.Length)];

                Console.WriteLine($"{phrase} {currEvent} {author} – {city}.");
            }         
        }
    }
}
