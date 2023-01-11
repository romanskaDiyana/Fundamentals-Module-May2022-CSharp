using System;
using System.Text.RegularExpressions;

namespace _03MatchDates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //03. Match Dates
            //Write a program, which matches a date in the format "dd{separator}MMM{separator}yyyy". Use named capturing groups in your regular expression.
            //            Compose the Regular Expression
            //Every valid date has the following characteristics:
            //    • Always starts with two digits, followed by a separator.
            //    • After that, it has one uppercase and two lowercase letters(e.g.Jan, Mar).
            //    • After that, it has a separator and exactly 4 digits(for the year).
            //    • The separator could be either of three things: a period('. '), a hyphen('-') or a forward -     slash      ('/').
            //    • The separator needs to be the same for the whole date(e.g. 13.03.2016 is valid, 13.03 / 2016   is          NOT).Use  a group backreference to check for this.
            //You can follow the table below to help with composing your RegEx:


            Regex regex = new Regex(@"(?<day>[0-9]{2})(?<separator>[\.\-\/])(?<month>[A-Z][a-z]{2})\k<separator>(?<year>[0-9]{4})");

            MatchCollection seekMatches = regex.Matches(Console.ReadLine());

            foreach (Match match in seekMatches)
            {
                Console.WriteLine($"Day: {match.Groups["day"]}, Month: {match.Groups["month"]}, Year: {match.Groups["year"]}");            
            }


        }
    }
}
