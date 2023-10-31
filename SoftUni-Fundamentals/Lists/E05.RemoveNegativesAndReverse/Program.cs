﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace E05.RemoveNegativesAndReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            numbers.RemoveAll(x => x < 0);
            if (numbers.Count==0)
            {
                Console.WriteLine("empty");
                return;
            }
            numbers.Reverse();
            Console.WriteLine(string.Join(" ", numbers));
            numbers.Select(x => x);
            
        }
    }
}
