using System;
using System.Collections.Generic;
using System.Linq;

namespace E05.SoftUniParking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> parking = new Dictionary<string, string>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] tokens= Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string command = tokens[0];
                if (command=="register")
                {
                    string name = tokens[1];
                    string licensePlate = tokens[2];
                    if (parking.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licensePlate}");
                        continue;
                    }
                    Console.WriteLine($"{name} registered {licensePlate} successfully");
                    parking.Add(name, licensePlate);
                }
                else if (command=="unregister")
                {
                    string name = tokens[1];
                    if (!parking.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                        continue;
                    }
                    Console.WriteLine($"{name} unregistered successfully");
                    parking.Remove(name);
                }
            }
            foreach (var item in parking)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
