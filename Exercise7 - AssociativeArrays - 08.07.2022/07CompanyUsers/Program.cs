using System;
using System.Collections.Generic;

namespace _07CompanyUsers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //07. Company Users
            //Create a program that keeps information about companies and their employees. 
            //You will be receiving a company name and an employee's id,
            //until you receive the "End" command. Add each employee to the given company.
            //Keep in mind that a company cannot have two employees with the same id.
            //When you finish reading the data, print the company's name and each
            //employee's id in the following format:
            //            { companyName}
            //            -- { id1}
            //            -- { id2}
            //            -- { idN}
            //            Input / Constraints
            //    • Until you receive the "End" command, you will be
            //    receiving input in the format: "{companyName} -> {employeeId}".
            //    • The input always will be valid.

            var companies = new Dictionary<string, List<string>>();

            string command = Console.ReadLine();

            while (command != "End")
            {
                var tokens = command.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                var companyName = tokens[0];    
                var employeeId = tokens[1];

                if (!companies.ContainsKey(companyName))
                {
                    companies.Add(companyName, new List<string>());
                }

                if (companies[companyName].Contains(employeeId))
                {
                    command = Console.ReadLine();
                    continue;
                }

                companies[companyName].Add(employeeId);

                command = Console.ReadLine();
            }

            foreach (var company in companies)
            {
                Console.WriteLine($"{company.Key}");

                foreach (var employeeId in company.Value)
                {
                    Console.WriteLine($"-- {employeeId}");
                }
            }
        }
    }
}
