using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace E08.Ranking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contestInfo = new Dictionary<string, string>();
            SortedDictionary<string, Dictionary<string, int>> contestParticipants = new SortedDictionary<string, Dictionary<string, int>>();


            string command = Console.ReadLine();
            while (command != "end of contests")
            {
                string[] tokens = command.Split(":");
                string contest = tokens[0];
                string password = tokens[1];
                contestInfo.Add(contest, password);
                command = Console.ReadLine();
            }

            command = Console.ReadLine();
            while (command != "end of submissions")
            {
                string[] tokens = command.Split("=>");
                string contest = tokens[0];
                string password = tokens[1];
                string participantName = tokens[2];
                int points = int.Parse(tokens[3]);

                if (!contestInfo.ContainsKey(contest) || contestInfo[contest] != password)
                {
                    command = Console.ReadLine();
                    continue;
                }

                if (!contestParticipants.ContainsKey(participantName))
                {
                    contestParticipants.Add(participantName, new Dictionary<string, int>());
                }
                if (!contestParticipants[participantName].ContainsKey(contest))
                {
                    contestParticipants[participantName].Add(contest, 0);
                }
                if (contestParticipants[participantName][contest] < points)
                {
                    contestParticipants[participantName][contest] = points;
                }

                command = Console.ReadLine();
            }

            string bestCandidate = contestParticipants.OrderByDescending(x => x.Value.Values.Sum()).Select(x=>x.Key).First();
            int maxPoints = contestParticipants[bestCandidate].Values.Sum();


            Console.WriteLine($"Best candidate is {bestCandidate} with total {maxPoints} points.");
            Console.WriteLine("Ranking:");

            foreach (var candidate in contestParticipants)
            {
                Console.WriteLine(candidate.Key);
                foreach (var info in candidate.Value.OrderByDescending(x=>x.Value))
                {
                    Console.WriteLine($"#  {info.Key} -> {info.Value}");
                }
            }

        }
    }
}
