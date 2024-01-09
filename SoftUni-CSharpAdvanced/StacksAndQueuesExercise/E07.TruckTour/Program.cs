using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace E07.TruckTour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPumps = int.Parse(Console.ReadLine());
            Queue<string> pumps = new Queue<string>();

            for (int i = 0; i < numberOfPumps; i++)
            {
                pumps.Enqueue(Console.ReadLine());
            }
            for (int index = 0; index < numberOfPumps; index++)
            {
                if (CanCompleteFullCircle(pumps))
                {
                    Console.WriteLine(index);
                    break;
                }
                pumps.Enqueue(pumps.Dequeue());
            }
        }
        static bool CanCompleteFullCircle(Queue<string> pumps)
        {
            bool isTrue = true;
            int fuel = 0;

            for (int i = 0; i < pumps.Count; i++)
            {
                int pumpFuel = int.Parse(pumps.Peek().Split().First());
                int distance = int.Parse(pumps.Peek().Split().Last());

                fuel += pumpFuel - distance;
                if (fuel < 0)
                {
                    isTrue = false;
                }
                pumps.Enqueue(pumps.Dequeue());
            }



            return isTrue;
        }
    }
}
