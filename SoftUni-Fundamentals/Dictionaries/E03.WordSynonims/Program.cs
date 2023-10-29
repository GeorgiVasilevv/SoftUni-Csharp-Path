using System;
using System.Collections.Generic;

namespace E03.WordSynonims
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> dic = new Dictionary<string, List<string>>();

            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (dic.ContainsKey(word))
                {
                    dic[word].Add(synonym);
                    continue;
                }
                dic.Add(word, new List<string>() { synonym });
                
            }

            foreach (var word in dic)
            {
                Console.WriteLine($"{word.Key} - {string.Join(", ", word.Value)}");
            }
        }
    }
}
