using System;
using System.Linq;

namespace E03.Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string wordToRemove = Console.ReadLine();
            string line = Console.ReadLine();

            while (line.Contains(wordToRemove))
            {
                int indexOfWord = line.IndexOf(wordToRemove);
                line = line.Remove(indexOfWord , wordToRemove.Length);
            }
            Console.WriteLine(line);
        }
    }
}
