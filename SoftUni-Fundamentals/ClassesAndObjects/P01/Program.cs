using System;
using System.Collections.Generic;
using System.Linq;

namespace P01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<string> words = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            for (int i = 0; i < words.Count; i++)
            {
                int randomNum=random.Next(0,words.Count);
                string currentWord = words[i];
                words[i] = words[randomNum];
                words[randomNum] = currentWord;
            }
            Console.WriteLine(string.Join("\n", words));

        }
    }
}
