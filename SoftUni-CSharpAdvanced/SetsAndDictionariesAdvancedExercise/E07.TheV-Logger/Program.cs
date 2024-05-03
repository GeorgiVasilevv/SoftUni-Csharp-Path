using System;
using System.Collections.Generic;
using System.Linq;

namespace E07.TheV_Logger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, SortedSet<string>> following = new Dictionary<string, SortedSet<string>>();

            Dictionary<string, SortedSet<string>> followedBy = new Dictionary<string, SortedSet<string>>();

            string command = Console.ReadLine();
            while (command != "Statistics")
            {
                string[] tokens = command.Split();
                string name = tokens.First();
                string name2 = tokens.Last();

                if (tokens[1] == "joined" && !following.ContainsKey(name))
                {
                    following.Add(name, new SortedSet<string>());
                    followedBy.Add(name, new SortedSet<string>());
                }
                else if (tokens[1] == "followed" && followedBy.ContainsKey(name2) && following.ContainsKey(name) && name != name2)
                {
                    following[name].Add(name2);
                    followedBy[name2].Add(name);
                }
                command = Console.ReadLine();
            }

            Console.WriteLine($"The V-Logger has a total of {following.Count} vloggers in its logs.");
            int ranking = 1;

            foreach (var vlogger in followedBy.OrderByDescending(x => x.Value.Count).ThenBy(x => following[x.Key].Count))
            {
                Console.WriteLine($"{ranking}. {vlogger.Key} : {vlogger.Value.Count} followers, {following[vlogger.Key].Count} following");
                if (ranking == 1)
                {
                    Console.WriteLine(String.Join("\n", vlogger.Value.Select(x => $"*  {x}")));
                }
                ranking++;
            }
        }
    }
}
