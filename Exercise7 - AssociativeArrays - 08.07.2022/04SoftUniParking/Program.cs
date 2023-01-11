using System;
using System.Collections.Generic;

namespace _04SoftUniParking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //04. SoftUni Parking
            //SoftUni just got a new parking lot.
            //It's so fancy, it even has online parking validation.
            //Except the online service doesn't work. It can only receive users'
            //data, but it doesn't know what to do with it. Good thing you're on the dev
            //team and know how to fix it, right?
            //Write a program, which validates a parking place for an online service.
            //Users can register to park and unregister to leave.

            //The program receives 2 commands:	
            //• "register {username} {licensePlateNumber}":
            //◦ The system only supports one car per user at the moment, so if a
            //user tries to register another license plate, using the same username,
            //the system should print:
            //"ERROR: already registered with plate number {licensePlateNumber}"
            //◦ If the aforementioned checks passes successfully, the plate can be
            //registered, so the system should print:
            // "{username} registered {licensePlateNumber} successfully"
            //• "unregister {username}":
            //◦ If the user is not present in the database, the system should print:
            //"ERROR: user {username} not found"
            //◦ If the aforementioned check passes successfully, the system should print:
            // "{username} unregistered successfully"
            //After you execute all of the commands, print all of the currently
            //registered users and their license plates in the format: 
            //• "{username} => {licensePlateNumber}"
            //Input
            //• First line: n - number of commands – integer.
            //• Next n lines: commands in one of the two possible formats:
            //◦ Register: "register {username} {licensePlateNumber}"
            //◦ Unregister: "unregister {username}"
            //The input will always be valid and you do not need to check it explicitly.

            Dictionary<string, string> users = new Dictionary<string, string>();

            int numberOfCmd = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCmd; i++)
            {
                var commands = Console.ReadLine().Split();
                var actions = commands[0];
                var userName = commands[1];

                switch (actions)
                {
                    case "register":
                        var plateNumber = commands[2];

                        if (CheckIfUserNameNotExist(users, userName))
                        {
                            users.Add(userName, plateNumber);
                            PrintResult($"{userName} registered {plateNumber} successfully");
                        }
                        else if (users.ContainsKey(userName))
                        {
                            PrintResult($"ERROR: already registered with plate number {plateNumber}");
                        }
                        break;
                    case "unregister":

                        if (CheckIfUserNameNotExist(users, userName))
                        {
                            PrintResult($"ERROR: user {userName} not found");
                        }
                        else
                        {
                            PrintResult($"{userName} unregistered successfully");
                            users.Remove(userName);
                        }
                        break;
                }
            }

            foreach (var user in users)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }

        static bool CheckIfUserNameNotExist(Dictionary<string, string> users, string name) 
            => !users.ContainsKey(name);


        static void PrintResult(string result) 
            => Console.WriteLine(result);
 
    }
}
