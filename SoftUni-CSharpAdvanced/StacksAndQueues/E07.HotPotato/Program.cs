using System;
using System.Collections;
using System.Collections.Generic;

namespace E07.HotPotato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            int n = int.Parse(Console.ReadLine());
            var kids = new Queue<string>(input);
            int tosses = 1;

            while (kids.Count > 1)
            {
                string currentKid = kids.Dequeue();

                if (tosses==n)
                {
                    Console.WriteLine($"Removed {currentKid}");
                    tosses = 1;
                    continue;
                }
                tosses++;
                kids.Enqueue(currentKid);
            }
            Console.WriteLine($"Last is {kids.Dequeue()}");
        }
    }
}
