using System;

namespace E02.CharacterMultiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            string word1 = words[0];
            string word2 = words[1];
            int minLen = Math.Min(word1.Length, word2.Length);
            int maxLen = Math.Max(word1.Length, word2.Length);
            int sum = 0;
            for (int i = 0; i < minLen; i++)
            {
                sum += MultiplyChars(word1[i], word2[i]);
            }
            if (word2.Length!=word1.Length)
            {
                string longerInput = word1.Length > word2.Length ? word1 : word2;
                for (int i = minLen; i < maxLen; i++)
                {
                    sum += longerInput[i];
                }
            }
            Console.WriteLine(sum);
        }
        static int MultiplyChars(char character1 , char character2)
        { 
            return character1 * character2;
        }
    }
}
