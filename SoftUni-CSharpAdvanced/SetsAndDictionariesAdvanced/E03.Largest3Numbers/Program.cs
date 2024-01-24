using System;
using System.Collections.Generic;
using System.Linq;

namespace E03.Largest3Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>(Console.ReadLine().Split().Select(int.Parse).ToList());
            nums = nums.OrderByDescending(n => n).ToList();

            int count = nums.Count;
            if (count > 3)
            {
                count = 3;
            }
            for (int i = 0; i < count; i++)
            {
                Console.Write(nums[i] + " ");
            }
        }
    }
}
