using System;
using System.Collections.Generic;
using System.Linq;

namespace E05.FashionBotique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> clothes = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());

            int rackCapacity = int.Parse(Console.ReadLine());

            int rackCounter = 0;
            int currentRackCapacity = 0;

            while (clothes.Count > 0)
            {
                if (currentRackCapacity - clothes.Peek() < 0)
                {
                    rackCounter++;
                    currentRackCapacity = rackCapacity;
                }
                else
                {
                    currentRackCapacity -= clothes.Pop();
                }
            }
            Console.WriteLine(rackCounter) ;
        }
    }
}
