using System;
using System.Collections.Generic;
using System.Linq;

namespace _05TeamworkProjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //05.Teamwork Projects
            //It's time for the teamwork projects and you are responsible for gathering the teams.
            //First, you will receive an integer – the count of the teams you will have to register.
            //You will be given a user and a team, separated with "-".
            //The user is the creator of the team. For every newly created team you should print a message: 

            // "Team {teamName} has been created by {user}!".
            //            Next, you will receive а user with a team, separated with "->", which means
            //            that the user wants to join that team. Upon receiving the command:
            //            "end of assignment", you should print every team, ordered by the count of
            //            its members(descending) and then by name(ascending). For each team, you
            //            have to print its members sorted by name(ascending).However, there are several rules:

            //    • If а user tries to create a team more than once, a message should be displayed:
            //        ◦ "Team {teamName} was already created!"
            //    • A creator of a team cannot create another team – the following message should be thrown: 
            //        ◦ "{user} cannot create another team!"
            //    • If а user tries to join a non-existent team, a message should be displayed:
            //        ◦ "Team {teamName} does not exist!"
            //    • A member of a team cannot join another team – the following message should be thrown:
            //        ◦ "Member {user} cannot join team {team Name}!"
            //    • In the end, teams with zero members(with only a creator) should disband and you have to print them ordered by name in ascending order. 
            //    •  Every valid team should be printed ordered by name(ascending) in the following format:
            //            "{teamName}
            //            - { creator}
            //            -- { member}…"


            int numberOfTeams = int.Parse(Console.ReadLine());

            var teams = new List<Team>();

            for (int i = 0; i < numberOfTeams; i++)
            {
                var currentTeamInfo = Console.ReadLine().Split("-");
                var creator = currentTeamInfo[0];
                var teamName = currentTeamInfo[1];

                if (teams.Any(x => x.Name == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else if (teams.Any(x => x.Creator == creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }
                else
                {
                    var team = new Team();
                    team.Name = teamName;
                    team.Creator = creator;
                    team.Members = new List<string>();
                    teams.Add(team);

                    Console.WriteLine($"Team {teamName} has been created by {creator}!");
                }
            }

            var line = Console.ReadLine();

            while (line != "end of assignment")
            {
            
                var memberName = line.Split(new string[] {"->"},StringSplitOptions.RemoveEmptyEntries)[0];
                var teamToJoin = line.Split(new string[] { "->" },StringSplitOptions.RemoveEmptyEntries)[1];

                if (teams.Any(x => x.Members.Contains(memberName))
                    || teams.Any(x => x.Creator == memberName))
                {
                    Console.WriteLine($"Member {memberName} cannot join team {teamToJoin}!");
                }
                else if (teams.All(x => x.Name != teamToJoin))
                {
                    Console.WriteLine($"Team {teamToJoin} does not exist!");
                }
                else
                {
                    var currentTeam = teams.Find(x => x.Name == teamToJoin);
                    currentTeam.Members.Add(memberName);
                }

                line = Console.ReadLine();
            }

            var completedTeams = teams.Where(x => x.Members.Count > 0).ToList();
            var disbanedTeams = teams.Where(x => x.Members.Count == 0).ToList();

            foreach (var team in completedTeams.OrderByDescending(team => team.Members.Count).ThenBy(y => y.Name))
            {
                Console.WriteLine($"{team.Name}");
                Console.WriteLine($"- {team.Creator}");
                foreach (var member in team.Members.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            Console.WriteLine($"Teams to disband:");
            if (disbanedTeams != null)
            {
                foreach (var disbanedTeam in disbanedTeams.OrderBy(x => x.Name))
                {
                    Console.WriteLine($"{disbanedTeam.Name}");
                }
            }
        }
    }

    class Team
    {
        public string Name { get; set; }

        public string Creator { get; set; }

        public List<string> Members { get; set; }
    }
}
