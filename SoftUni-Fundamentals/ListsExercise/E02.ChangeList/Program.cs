using System;
using System.Collections.Generic;
using System.Linq;

namespace E02.ChangeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToList();

            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] commands = command.Split().ToArray();
                string deleteOrInsert = commands[0];
                if (deleteOrInsert == "Delete")
                {
                    int element = int.Parse(commands[1]);
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i]==element)
                        {
                            numbers.Remove(element);
                            i--;
                        }
                    }
                }
                else if (deleteOrInsert== "Insert")
                {
                    int element = int.Parse(commands[1]);
                    int position = int.Parse(commands[2]); // index
                    numbers.Insert(position, element);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
