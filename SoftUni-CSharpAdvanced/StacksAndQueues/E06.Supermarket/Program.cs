using System;
using System.Collections;
using System.Collections.Generic;

namespace E06.Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Queue<string> queue = new Queue<string>();

            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] tokens = command.Split(' ');

                if (tokens[0] == "Paid")
                {
                    while (queue.Count != 0)
                    {
                        Console.WriteLine(queue.Dequeue());
                    }
                }
                else
                {
                    queue.Enqueue(tokens[0]);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(queue.Count + " people remaining.");
        }
    }
}
