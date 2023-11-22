using System;
using System.Collections.Generic;
using System.Linq;

namespace E03.LegendaryFarming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> farming = new Dictionary<string, int>()
            {
                {"shards",0 },
                {"motes",0 },
                {"fragments",0 },


            };

            Dictionary<string, string> craftingTable = new Dictionary<string, string>()
            {
                {"shards","Shadowmourne" },
                {"fragments","Valanyr" },
                {"motes","Dragonwrath" },
            };
            string[] namesOfMaterials = { "shards", "fragments", "motes" };
            bool isCrafted = false;
            while (true)
            {
                string[] tokens = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(t => t.ToLower())
                    .ToArray();
                for (int i = 0; i < tokens.Length; i += 2)
                {
                    int quantity = int.Parse(tokens[i]);
                    string ore = tokens[i + 1];

                    if (namesOfMaterials.Contains(ore)) // checks if ore is valid
                    {
                        farming[ore] += quantity;

                        if (farming[ore] >= 250)
                        {
                            string itemCrafted = craftingTable[ore];
                            farming[ore] -= 250;
                            Console.WriteLine($"{itemCrafted} obtained!");
                            isCrafted = true;
                            break;
                        }
                    }
                    else //checks if ore is junk
                    {
                        if (farming.ContainsKey(ore))
                        {
                            farming[ore] += quantity;
                        }
                        else
                        {
                            farming.Add(ore, quantity);
                        }
                    }
                }
                if (isCrafted)
                {
                    break;
                }
            }
                foreach (var item in farming)
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }
        }
    }
}
