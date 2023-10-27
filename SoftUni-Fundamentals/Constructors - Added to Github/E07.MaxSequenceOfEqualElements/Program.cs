using System;
using System.Linq;

namespace E07.MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
               .Split(' ', StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray();
            int count = 1;
            int longestCount = 1;
            int currentLongest = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i]!=array[i-1])
                {
                    count = 0;
                }
                count++;
                if (count>longestCount)
                {
                    longestCount = count;
                    currentLongest = array[i];
                }
            }
            Console.WriteLine(
    string.Join(" ", Enumerable.Repeat(currentLongest, longestCount)));

        }
    }
}
