using System;
using System.Collections.Generic;

namespace E08.TrafficJam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int passingCars = int.Parse(Console.ReadLine());
            Queue<string> queue = new Queue<string>();

            string command;
            int passedCarsCount = 0;
            while ((command = Console.ReadLine()) != "end")
            {
                

                if (command == "green")
                {
                    for (int i = 0; i < passingCars; i++)
                    {
                        if (queue.Count == 0)
                        {
                            break;
                        }
                        Console.WriteLine(queue.Dequeue() + " passed!");
                        passedCarsCount++;
                    }
                }
                else
                {
                    queue.Enqueue(command);
                }
            }
            Console.WriteLine($"{passedCarsCount} cars passed the crossroads.");
        }
    }
}
