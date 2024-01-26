using System;
using System.Collections.Generic;

namespace E06.RecordUniqueNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                set.Add(name);
                Console.WriteLine();
            }
            foreach (var item in set)
            {
                Console.WriteLine(item);
            }
        }
    }
}
