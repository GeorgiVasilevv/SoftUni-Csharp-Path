using System;
using System.Collections.Generic;
using System.Linq;

namespace Е010.ForceBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, SortedSet<string>> forceUsers = new Dictionary<string, SortedSet<string>>();

            //    string command;
            //    while ((command = Console.ReadLine()) != "Lumpawaroo")
            //    {
            //        if (command.Contains(" | "))
            //        {
            //            string[] tokens = command.Split(" | ", StringSplitOptions.RemoveEmptyEntries);
            //            string forceSide = tokens[0];
            //            string forceUser = tokens[1];

            //            if (!forceUsers.Values.Any(u => u.Contains(forceUser)))
            //            {

            //                if (!forceUsers.ContainsKey(forceSide))
            //                {
            //                    forceUsers.Add(forceSide, new SortedSet<string>());
            //                }
            //                forceUsers[forceSide].Add(forceUser);
            //            }

            //        }
            //        else if (command.Contains(" -> "))
            //        {
            //            string[] tokens = command.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
            //            string forceUser = tokens[0];
            //            string forceSide = tokens[1];

            //            foreach (var sideUser in forceUsers)
            //            {
            //                if (sideUser.Value.Contains(forceUser))
            //                {
            //                    sideUser.Value.Remove(forceUser);
            //                    break;
            //                }
            //            }

            //            if (!forceUsers.ContainsKey(forceSide))
            //            {
            //                forceUsers.Add(forceSide, new SortedSet<string>());
            //            }
            //            forceUsers[forceSide].Add(forceUser);
            //            Console.WriteLine($"{forceUser} joins the {forceSide} side!");
            //        }
            //    }

            //    var filteredDict = forceUsers
            //    .Where(x => x.Value.Count > 0)
            //    .OrderByDescending(x => x.Value.Count)
            //    .ThenBy(x => x.Key);

            //    foreach (var side in filteredDict)
            //    {
            //        Console.WriteLine($"Side: {side.Key}, Members: {side.Value.Count}");
            //        foreach (var user in side.Value.OrderBy(x => x))
            //        {
            //            Console.WriteLine($"! {user}");
            //        }

            //    }



            string command;
            while ((command = Console.ReadLine()) != "Lumpawaroo")
            {
                if (command.Contains(" | "))
                {
                    string[] tokens = command.Split(" | ", StringSplitOptions.RemoveEmptyEntries);
                    string forceSide = tokens[0];
                    string forceUser = tokens[1];
                    //if (!forceUsers.ContainsKey(forceSide))
                    //{
                    //    forceUsers.Add(forceSide, new SortedSet<string>());
                    //}
                    //forceUsers[forceSide].Add(forceUser);
                    if (!forceUsers.Values.Any(u => u.Contains(forceUser)))
                    {

                        if (!forceUsers.ContainsKey(forceSide))
                        {
                            forceUsers.Add(forceSide, new SortedSet<string>());
                        }
                        forceUsers[forceSide].Add(forceUser);
                    }

                    //        }

                }
                else if (command.Contains(" -> "))
                {
                    string[] tokens = command.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                    string forceUser = tokens[0];
                    string forceSide = tokens[1];

                    if (forceUsers.Any(x => x.Value.Contains(forceUser)))
                    {

                        string sideToRemoveFrom = forceUsers.Where(x => x.Value.Contains(forceUser)).First().Key;
                        forceUsers[sideToRemoveFrom].Remove(forceUser);

                    }
                    if (!forceUsers.ContainsKey(forceSide))
                    {
                        forceUsers.Add(forceSide, new SortedSet<string>());
                    }
                    forceUsers[forceSide].Add(forceUser);
                    Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                }
            }

            var filteredDict = forceUsers
            .Where(x => x.Value.Count > 0)
            .OrderByDescending(x => x.Value.Count)
            .ThenBy(x => x.Key);

            foreach (var side in filteredDict)
            {
                Console.WriteLine($"Side: {side.Key}, Members: {side.Value.Count}");
                foreach (var user in side.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"! {user}");
                }

            }
        }
    }
}
