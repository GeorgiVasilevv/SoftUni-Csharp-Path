using System;
using System.Collections.Generic;
using System.Linq;

namespace E02.BasicQueueOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] stackArgs = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int n = stackArgs[0];
            int numbersToDequeue = stackArgs[1];
            int numberToLook = stackArgs[2];

            Queue<int> queue = new Queue<int>(Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray());

            for (int i = 0; i < numbersToDequeue; i++)
            {
                queue.Dequeue();
            }

            if (queue.Contains(numberToLook))
            {
                Console.WriteLine("true");
            }
            else if (queue.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(queue.Min());
            }
        }
    }
}
