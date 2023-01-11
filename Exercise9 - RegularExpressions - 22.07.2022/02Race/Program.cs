using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02Race
{
    internal class Program
    {
        private static object diction;
        private static string regex;

        static void Main(string[] args)
        {
            //02.Race
            //Write a program that processes information about a race. On the first line, you will be given a list of participants separated by ", ". On the next few lines, until you receive a line "end of the race", you will be given some info which will be some alphanumeric characters. In between them, you could have some extra characters which you should ignore. For example: "G!32e%o7r#32g$235@!2e". The letters are the name of the person and the sum of the digits is the distance he ran. So here we have George who ran 29 km. Store the information about the person only if the list of racers contains the name of the person. If you receive the same person more than once, just add the distance to his old distance. At the end print the top 3 racers in the format:
            //            "1st place: {first racer}
            //2nd place: { second racer}
            //            3rd place: { third racer}
            //            "

            Regex patternForName = new Regex(@"(?<nameOfRacers>[A-Za-z]+)");
            string patternForKm = @"(?<kmForEachReacer>\d+)";

            int sumOfKm = 0;

            var participants = new Dictionary<string, int>();

            var listOfNames = Console.ReadLine().Split(", ").ToList();

            string input = Console.ReadLine();



            while (input != "end of race")
            {
                MatchCollection matchedNames = patternForName.Matches(input);
                MatchCollection matchedDigit = Regex.Matches(input, patternForKm);



                string currentName = string.Join("", matchedNames);
                string currentKm = string.Join("", matchedDigit);

                sumOfKm = 0;

                for (int i = 0; i < currentKm.Length; i++)
                {
                    sumOfKm += int.Parse(currentKm[i].ToString()); 
                }

                if (listOfNames.Contains(currentName))
                {
                    if (!participants.ContainsKey(currentName))
                    {
                        participants.Add(currentName, sumOfKm);
                    }
                    else
                    {
                        participants[currentName] += sumOfKm;
                    }
                }

                input = Console.ReadLine();
            }

            var winners = participants.OrderByDescending(x => x.Value).Take(3);

            var firstPlace = winners.Take(1);
            var secondPlace = winners.OrderByDescending(x => x.Value).Take(2).OrderBy(x=>x.Value).Take(1);
            var thirdPlace = winners.OrderBy(x => x.Value).Take(1);

            foreach (var firstName in firstPlace)
            {
                Console.WriteLine($"1st place: {firstName.Key}");
            }

            foreach (var secondName in secondPlace)
            {
                Console.WriteLine($"2nd place: {secondName.Key}");
            }

            foreach (var thirdName in thirdPlace)
            {
                Console.WriteLine($"3rd place: {thirdName.Key}");
            }
        }
    }
}
