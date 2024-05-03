using System;
using System.Collections.Generic;

namespace E05.CountSymbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<char,int> chars = new SortedDictionary<char,int>();

            string word = Console.ReadLine();
            for (int i = 0; i < word.Length; i++)
            {
                char ch = word[i];

                if (!chars.ContainsKey(ch))
                {
                    chars.Add(ch, 0);
                }
                chars[ch]++;
            }

            foreach (var @char in chars)
            {
                Console.WriteLine($"{@char.Key}: {@char.Value} time/s");
            }
        }
    }
}
