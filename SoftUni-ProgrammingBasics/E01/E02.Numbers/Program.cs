using System;
using System.Collections.Generic;
using System.Linq;

namespace E02.Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            string cmd = Console.ReadLine();
            while (cmd!="Finish")
            {
                string[] split = cmd.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string command= split[0];

                if (command == "Add")
                {
                    int value =int.Parse(split[1]);

                    numbers.Add(value);
                }
                else if (command == "Remove")
                {
                    int value = int.Parse(split[1]);

                    numbers.Remove(value);
                }
                else if (command == "Replace")
                {
                    int value = int.Parse(split[1]);
                    int replacement = int.Parse(split[2]);

                    int index=numbers.IndexOf(value);
                    numbers.Remove(value);
                    numbers.Insert(index, replacement);
                }
                else if (command == "Collapse")
                {
                    int value = int.Parse(split[1]);
                    numbers.RemoveAll(x => x < value);
                }
                cmd = Console.ReadLine();
            }
            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
