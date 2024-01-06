using System;
using System.Collections.Generic;
using System.Linq;

namespace E03.MaximumAndMinimumElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                int[] command = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (command[0] == 1)
                {
                    int numToPush = command[1];
                    stack.Push(numToPush);
                }
                else if (command[0] == 2)
                {
                    if (stack.Count == 0)
                    {
                        continue;
                    }
                    stack.Pop();
                }
                else if (command[0] == 3)
                {
                    if (stack.Count == 0)
                    {
                        continue;
                    }
                    Console.WriteLine(stack.Max()) ;
                }
                else if (command[0] == 4)
                {
                    if (stack.Count == 0)
                    {
                        continue;
                    }
                    Console.WriteLine(stack.Min());
                }
            }
            Console.WriteLine(String.Join(", ",stack));
        }
    }
}
