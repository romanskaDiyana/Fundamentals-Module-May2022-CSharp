using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace _05Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //05. Login
            //On the first line, you will be given a username and your task is to try to log in the user.
            //The user's password is the username reversed. On the next lines, you will receive passwords:
            //    • If the password is incorrect, print "Incorrect password. Try again.".
            //    • If the password is correct, print "User {username} logged in." and stop the program.
            //Keep in mind that if the password is still incorrect on the fourth attempt, you should print: "User {username} blocked!".
            //Then the program stops.


            //string username = Console.ReadLine(); 
            //char[] charUsername = username.ToCharArray();
            //Array.Reverse(charUsername);

            //Console.WriteLine(charUsername);

            string username = Console.ReadLine();        
            char[] usernameInChar = username.ToCharArray();
            Array.Reverse(usernameInChar);
            string correctPassword = new string(usernameInChar);

            string inputPassword = Console.ReadLine();

            CheckPassword(inputPassword, correctPassword, username);                 
        }

        static void CheckPassword(string inputPassword, string correctPassword,string username)
        {
            int counterOfWrongAttempts = 0;

            while (true)
            {
                if (inputPassword == correctPassword)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                else
                {
                    if (counterOfWrongAttempts == 3)
                    {
                        Console.WriteLine($"User {username} blocked!");
                        return;
                    }

                    Console.WriteLine("Incorrect password. Try again.");
                    counterOfWrongAttempts++;
                }

                inputPassword = Console.ReadLine();
            }
        }
    }
}
