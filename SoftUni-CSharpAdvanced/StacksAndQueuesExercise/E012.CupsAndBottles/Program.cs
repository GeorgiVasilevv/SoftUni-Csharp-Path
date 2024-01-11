using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace E012.CupsAndBottles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> cups = new Queue<int>(Console.ReadLine()
                .Split()
                .Select(x => int.Parse(x))
                .ToArray());

            Stack<int> bottles = new Stack<int>(Console.ReadLine()
               .Split()
               .Select(x => int.Parse(x))
               .ToArray());

            int wastedLitres = 0;
            int currCup=0;

            while (cups.Any() && bottles.Any())
            {
                int currBottle = bottles.Peek();
                if (currCup <= 0)
                {

                 currCup= cups.Peek();
                }

                if (currBottle >= currCup)
                {
                    currBottle -= currCup;
                    wastedLitres += currBottle;
                    bottles.Pop();
                    cups.Dequeue();
                    currBottle = 0;
                }
                else
                {
                    currCup -= currBottle;
                    bottles.Pop();
                }



            }

            if (cups.Any())
            {
                Console.WriteLine($"Cups: {String.Join(" ", cups)}");
                Console.WriteLine($"Wasted litters of water: {wastedLitres}");
            }
            else
            {
                Console.WriteLine($"Bottles: {String.Join(" ", bottles)}");
                Console.WriteLine($"Wasted litters of water: {wastedLitres}");
            }
        }
    }
}
