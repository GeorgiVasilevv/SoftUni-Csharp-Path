using System;
using System.Collections.Generic;
using System.Linq;

namespace E01.BasicStackOperations
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
            int numbersToPop = stackArgs[1];
            int numberToLook = stackArgs[2];

            Stack<int> stack = new Stack<int>(Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray());

            for (int i = 0; i < numbersToPop; i++)
            {
                stack.Pop();
            }

            if (stack.Contains(numberToLook))
            {
                Console.WriteLine("true");
            }
            else if (stack.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(stack.Min());
            }
        }
    }
}
