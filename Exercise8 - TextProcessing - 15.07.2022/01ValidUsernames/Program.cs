using System;
using System.Collections.Generic;

namespace _01ValidUsernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //01.Valid Usernames
            //Create a program that reads user names on a single line (joined by ", ") and prints all valid usernames. 
            //A valid username
            //• has length between 3 and 16 characters
            //• contains only letters, numbers, hyphens and underscores

            string[] usernames = Console.ReadLine().Split(", ");

            foreach (string currentUsername in usernames)
            {
                if (currentUsername.Length > 3 && currentUsername.Length <= 16)
                {
                    bool isUsernameValid = true;

                    foreach (var currentChar in currentUsername)
                    {
                        if (!(char.IsLetterOrDigit(currentChar) || currentChar == '-' || currentChar == '_'))
                        {
                            isUsernameValid = false;
                            break;
                        }
                    }

                    if (isUsernameValid)
                    {
                        Console.WriteLine(currentUsername);
                    }
                }
            }
        }
    }
}



