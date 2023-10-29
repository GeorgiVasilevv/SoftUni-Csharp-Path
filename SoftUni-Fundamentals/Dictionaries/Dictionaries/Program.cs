

using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictionaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            SortedDictionary<int, int> numbers = new SortedDictionary<int, int>();

            foreach (int item in nums)
            {
                if (numbers.ContainsKey(item))
                {
                    numbers[item]++;
                }
                else
                {
                    numbers.Add(item, 1);
                }
            }
            foreach (var item in numbers)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

        }
    }
}
