using System;
using System.Collections.Generic;
using System.Linq;

namespace E03.PeriodicTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> periodicTable = new HashSet<string>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split();
                periodicTable.UnionWith(tokens);
            }
            Console.WriteLine(string.Join(" ",periodicTable.OrderBy(x=> x)));
        }
    }
}
