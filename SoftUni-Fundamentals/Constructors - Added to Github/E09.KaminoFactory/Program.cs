using System;
using System.Linq;

namespace E09.KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            string sequences = Console.ReadLine();

            int count = 1;
            int longestCount = 1;
            int bestSumOfArrays = 0;
            int currentLongest = array[0];
            int bestIndex = 0;
            while (sequences != "Clone them!")
            {
                array = sequences
                    .Split("!", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                int[] bestSample = new int[array.Length];
                int sumOfArrays = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    bestSample[i] = array[i];
                    sumOfArrays += array[i];
                }

                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] != array[i - 1])
                    {
                        count = 0;
                    }
                    count++;

                    if (count >= longestCount)
                    {
                        if (count == longestCount)
                        {
                            if (sumOfArrays > bestSumOfArrays)
                            {
                                longestCount = count;
                                bestSample = array;
                                currentLongest = array[i];
                                bestSumOfArrays = sumOfArrays;
                                bestIndex = i;
                            }

                        }
                        else if (count > longestCount)
                        {
                            longestCount = count;
                            bestSample = array;
                            currentLongest = array[i];
                            bestIndex = i - 1;
                            bestSumOfArrays = sumOfArrays;

                        }
                    }
                }
                sequences = Console.ReadLine();
                if (sequences == "Clone them!")
                {
                    Console.WriteLine($"Best DNA sample {bestIndex} with sum: {sumOfArrays}.");
                    Console.WriteLine(string.Join(' ', bestSample));
                }
            }



        }
    }
}
