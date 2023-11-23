using System;
using System.Collections.Generic;
using System.Linq;

namespace E08.CompanyUsers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> users = new Dictionary<string, List<string>>();
            string cmd = Console.ReadLine();
            while (cmd != "End")
            {
                string[] tokens = cmd.Split(" -> ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string companyName = tokens[0];
                string userId = tokens[1];

                if (users.ContainsKey(companyName))
                {
                    if (users[companyName].Contains(userId))
                    {
                        cmd = Console.ReadLine();
                        continue;
                    }
                    users[companyName].Add(userId);
                }
                else
                {
                    users.Add(companyName, new List<string>() { userId });
                }
                cmd = Console.ReadLine();
            }
            foreach (var item in users)
            {
                Console.WriteLine($"{item.Key}");
                foreach (var item2 in item.Value)
                {
                    Console.WriteLine($"-- {item2}");
                }
            }
        }
    }
}
