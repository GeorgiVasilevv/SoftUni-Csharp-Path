﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace E06.ListManipulationBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();
            while (command!= "end")
            {
                string[] line = command.Split(" ");
                 string action= line[0];

                if (action=="Add")
                {
                    int itemToAdd = int.Parse(line[1]);

                    numbers.Add(itemToAdd);
                }

                else if (action == "Remove")
                {
                    int itemToRemove= int.Parse(line[1]);

                    numbers.Remove(itemToRemove);
                }

                else if (action == "RemoveAt")
                {
                    int indexToRemove = int.Parse(line[1]);

                    numbers.RemoveAt(indexToRemove);
                }

                else if (action=="Insert")
                {
                    int numToInsert = int.Parse(line[1]);
                    int indexToInsert = int.Parse(line[2]);

                    numbers.Insert(indexToInsert, numToInsert);


                }

                command = Console.ReadLine();

            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
