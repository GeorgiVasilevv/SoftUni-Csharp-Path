using System;
using System.Linq;

namespace KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string sequences = Console.ReadLine();
            int bestCurrentLength = 1;
            int bestStartIndex = 0;
            int bestSequenceSum = 0;
            int sequenceCounter = 0;
            int bestCurrentSequence = 0;
            int[] bestSequence = new int[n];
            while (sequences != "Clone them!")
            {
                int[] currentSequence = sequences
                    .Split('!', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                sequenceCounter++;
                int length = 1;
                int currentLength = 1;
                int bestLengthIndex = 0;
                int currentSum = 0;
                for (int i = 0; i < currentSequence.Length - 1; i++)
                {
                    if (currentSequence[i] == currentSequence[i + 1])
                    {
                        length++;
                    }
                    else
                    {
                        length = 1;
                    }
                    if (length > currentLength)
                    {
                        currentLength = length;
                        bestLengthIndex = i;
                    }
                    currentSum += currentSequence[i];

                }
                currentSum += currentSequence[n-1];
                if (currentLength > bestCurrentLength)
                {
                    bestCurrentLength = currentLength;
                    bestStartIndex = bestLengthIndex;
                    bestSequenceSum = currentSum;
                    bestCurrentSequence = sequenceCounter;
                    bestSequence = currentSequence.ToArray();

                }
                else if (bestCurrentLength == currentLength)
                {
                    if (bestStartIndex > bestLengthIndex)
                    {
                        bestCurrentLength = currentLength;
                        bestStartIndex = bestLengthIndex;
                        bestSequenceSum = currentSum;
                        bestCurrentSequence = sequenceCounter;
                        bestSequence = currentSequence.ToArray();

                    }
                    else if (bestStartIndex == bestLengthIndex)
                    {
                        if (bestSequenceSum < currentSum)
                        {
                            bestCurrentLength = currentLength;
                            bestStartIndex = bestLengthIndex;
                            bestSequenceSum = currentSum;
                            bestCurrentSequence = sequenceCounter;
                            bestSequence = currentSequence.ToArray();

                        }
                    }
                }
                sequences = Console.ReadLine();
            }
            Console.WriteLine($"Best DNA sample {bestCurrentSequence} with sum: {bestSequenceSum}.");
            Console.WriteLine(string.Join(' ', bestSequence));
        }
    }
}
