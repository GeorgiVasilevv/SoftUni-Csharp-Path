using System;
using System.Collections.Generic;
using System.Linq;

namespace E06.ReplaceRepeatingChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            List<char> chars = word.ToCharArray().ToList();
            for (int i = 1; i < chars.Count; i++)
            {
                if (chars[i-1] ==chars[i])
                {
                    chars.RemoveAt(i);
                    i--;
                }
            }
            Console.WriteLine(String.Join("",chars));
        }
    }
}
