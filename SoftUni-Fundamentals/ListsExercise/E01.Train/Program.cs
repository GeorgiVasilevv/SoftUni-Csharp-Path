﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace E01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int maxCapacity = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] commands = command.Split().ToArray();
                string checkForAdd = commands[0];
                if (checkForAdd == "Add")
                {
                    int passengers = int.Parse(commands[1]);
                    wagons.Add(passengers);
                }
                else
                {
                    int passengers = int.Parse(commands[0]);
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + passengers <= maxCapacity)
                        {
                            wagons[i] += passengers;
                            break;
                        }
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(String.Join(" ", wagons));
        }
    }
}
