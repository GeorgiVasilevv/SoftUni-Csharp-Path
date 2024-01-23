using System;
using System.Collections.Generic;
using System.Linq;

namespace E01.CountSameValuesInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<double,int> occurences = new Dictionary<double, int>();
            double[] input = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();
            for (int i = 0; i < input.Length; i++)
            {
                if (!occurences.ContainsKey(input[i]))
                {
                    occurences.Add(input[i], 0);
                }
                occurences[input[i]]++;
            }

            foreach (var item in occurences)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}
