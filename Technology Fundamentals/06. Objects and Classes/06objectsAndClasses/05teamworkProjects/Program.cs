using System;
using System.Collections.Generic;
using System.Linq;

namespace _05teamworkProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split('-');

                string creator = input[0];
                string teamName = input[1];
                Team team = new Team();
                team.Creator = creator;
                team.TeamName = teamName;

                List<string> membersList = new List<string>();
                team.Members = membersList;
                if (!teams.Select(x => x.TeamName).Contains(team.TeamName))
                {
                    if (!teams.Select(x => x.Creator).Contains(team.Creator))
                    {
                        teams.Add(team);
                        Console.WriteLine($"Team {teamName} has been created by {creator}!");
                    }
                    else
                    {
                        Console.WriteLine($"{team.Creator} cannot create another team!");
                    }
                }
                else
                {
                    Console.WriteLine($"Team {team.TeamName} was already created!");
                }
            }
            

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end of assignment")
                {
                    break;
                }
                string[] inputParts = input.Split("->");
                string user = inputParts[0];
                string teamName = inputParts[1];

                if (!teams.Select(x => x.TeamName).Contains(teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else if (teams.Select(x => x.Members).Any(x => x.Contains(user)) 
                    || teams.Select(x => x.Creator).Contains(user))
                {
                    Console.WriteLine($"Member {user} cannot join team {teamName}!");
                }
                else
                {
                    int teamToJoinIndex = teams.FindIndex(x => x.TeamName == teamName);
                    teams[teamToJoinIndex].Members.Add(user);
                }
            }
            var teamsToDisband = teams.OrderBy(x => x.TeamName).Where(x => x.Members.Count == 0);
            var fullTeams = teams.
            OrderByDescending(x => x.Members.Count).
            ThenBy(x => x.TeamName).
            Where(x => x.Members.Count > 0);

            foreach (var team in fullTeams)
            {
                Console.WriteLine($"{team.TeamName}");
                Console.WriteLine($"- {team.Creator}");
                foreach (var member in team.Members.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            Console.WriteLine("Teams to disband:");
            foreach (var item in teamsToDisband)
            {
                Console.WriteLine(item.TeamName);
            }
        }

    }


    class Team
    {
        public string TeamName { get; set; }
        public string Creator { get; set; }
        public List<string> Members { get; set; }
    }
}

