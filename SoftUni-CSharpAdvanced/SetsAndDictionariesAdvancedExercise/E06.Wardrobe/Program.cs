using System;
using System.Collections.Generic;

namespace E06.Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> clothes = new Dictionary<string, Dictionary<string, int>>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split(new string[] { ","," -> "   },StringSplitOptions.RemoveEmptyEntries);

                string color = tokens[0];

                if (!clothes.ContainsKey(color))
                {
                    clothes.Add(color, new Dictionary<string, int>());
                }

                for (int j = 1; j < tokens.Length; j++)
                {
                    if (!clothes[color].ContainsKey(tokens[j]))
                    {
                        clothes[color].Add(tokens[j], 0);
                    }
                    clothes[color][tokens[j]]++;
                }
            }

            string[] clothing = Console.ReadLine().Split();

            foreach (var color in clothes)
            {
                Console.WriteLine($"{color.Key} clothes:");
                foreach (var cloth in color.Value)
                {
                    string output = $"* {cloth.Key} - {cloth.Value}";
                    if (color.Key == clothing[0] && cloth.Key == clothing[1])
                    {
                        output += " (found!)";
                    }
                    Console.WriteLine(output);
                }
            }
        }
    }
}
