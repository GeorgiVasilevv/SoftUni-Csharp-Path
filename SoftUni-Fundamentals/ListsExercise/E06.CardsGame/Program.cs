using System;
using System.Collections.Generic;
using System.Linq;

namespace E06.CardsGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> deckOne = Console.ReadLine()
               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToList();
            List<int> deckTwo = Console.ReadLine()
               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToList();

            while (deckOne.Count > 0 && deckTwo.Count > 0)
            {
                
                if (deckOne[0] > deckTwo[0])
                {
                    deckOne.Add(deckTwo[0]);
                    deckOne.Add(deckOne[0]);
                }
                else if ((deckOne[0] < deckTwo[0]))
                {
                    deckTwo.Add(deckOne[0]);
                    deckTwo.Add(deckTwo[0]);
                }
                deckTwo.Remove(deckTwo.First());
                deckOne.Remove(deckOne.First());


            }
            if (deckOne.Count<=0)
            {
                Console.WriteLine($"Second player wins! Sum: {deckTwo.Sum()}");
                return;
            }
            else if (deckTwo.Count<=0)
            {
                Console.WriteLine($"First player wins! Sum: {deckOne.Sum()}");
                return;
            }
        }
    }
}
