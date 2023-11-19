using System;
using System.Collections.Generic;
using System.Linq;

namespace E05.TeamworkProjects
{
    class Team
    {
        public Team(string user, string teamName)
        {
            this.User = user;
            this.TeamName = teamName;
            Console.WriteLine($"Team {this.TeamName} has been created by {this.User}!");
            this.Members = new List<string>();
        }
        public string User { get; set; }
        public string TeamName { get; set; }
        public List<string> Members { get; set; }

        public void AddMember(string member)
        {
            this.Members.Add(member);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split("-", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string user = tokens[0];
                string teamName = tokens[1];

                if (teams.Any(t => t.TeamName == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }
                if (teams.Any(t => t.User == user))
                {
                    Console.WriteLine($"{user} cannot create another team!");
                    continue;
                }

                Team team = new Team(user, teamName);
                teams.Add(team);
            }
            string cmd = Console.ReadLine();
            while (cmd != "end of assignment")
            {
                string[] tokens = cmd.Split("->", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string memberName = tokens[0];
                string teamName = tokens[1];

                Team searchedTeam = teams.FirstOrDefault(t => t.TeamName == teamName);

                if (searchedTeam == null)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                    cmd = Console.ReadLine();
                    continue;
                }
                if (teams.Any(m => m.Members.Contains(memberName)))
                {
                    Console.WriteLine($"Member {memberName} cannot join team {teamName}!");
                    cmd = Console.ReadLine();
                    continue;
                }

                if (teams.Any(t => t.User == memberName))
                {
                    //Creator of a team cannot be a member of another team
                    Console.WriteLine($"Member {memberName} cannot join team {teamName}!");
                    cmd = Console.ReadLine();
                    continue;
                }// if there is an error //TODO


                searchedTeam.AddMember(memberName);
                cmd = Console.ReadLine();
            }

            List<Team> validTeams = teams.Where(t => t.Members.Count > 0)
                                         .OrderByDescending(t => t.Members.Count)
                                         .ThenBy(t => t.TeamName)
                                         .ToList();
            List<Team> disbandTeams = teams.Where(t => t.Members.Count == 0)
                                           .OrderBy(t => t.TeamName)
                                           .ToList();
            PrintTeam(validTeams);
            Console.WriteLine("Teams to disband:");
            foreach (Team team in disbandTeams)
            {
                Console.WriteLine(team.TeamName);
            }
        }
        public static void PrintTeam(List<Team> validTeams)
        {
            foreach (Team team in validTeams)
            {
                Console.WriteLine($"{team.TeamName}");
                Console.WriteLine($"- {team.User}");
                foreach (string item in team.Members.OrderBy(m => m))
                {
                    Console.WriteLine($"-- {item}");
                }

            }
        }
    }
}
