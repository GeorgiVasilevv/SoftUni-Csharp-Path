﻿using System;
using System.Collections.Generic;

namespace E01.UniqueUsernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> names = new HashSet<string>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                names.Add(Console.ReadLine());

            }
            Console.WriteLine(String.Join("\n", names));
        }
    }
}
