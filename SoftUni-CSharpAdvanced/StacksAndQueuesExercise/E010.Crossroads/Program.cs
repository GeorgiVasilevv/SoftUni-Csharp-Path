using System;
using System.Collections.Generic;

namespace E010.Crossroads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int greenLightDuration = int.Parse(Console.ReadLine());
            int freeWindowDuration = int.Parse(Console.ReadLine());
            int totalCarsPassed = 0;
            Queue<string> queuedCars = new Queue<string>();

            while (true)
            {
                string token = Console.ReadLine();

                if (token == "END")
                {
                    break;
                }
                else if (token == "green" && queuedCars.Count > 0)
                {
                    string currCar = queuedCars.Dequeue();
                    Queue<char> passingCarChars = new Queue<char>(currCar);

                    for (int i = 0; i < greenLightDuration; i++)
                    {
                        if (passingCarChars.Count > 0)
                        {
                            passingCarChars.Dequeue();
                            if (passingCarChars.Count == 0)
                            {
                                totalCarsPassed++;
                            }
                        }
                        else if (queuedCars.Count > 0)
                        {
                            currCar = queuedCars.Dequeue();
                            foreach (char ch in currCar)
                            {
                                passingCarChars.Enqueue(ch);
                            }
                            passingCarChars.Dequeue();
                        }
                    }


                    for (int i = 0; i < freeWindowDuration; i++)
                    {
                        if (passingCarChars.Count > 0)
                        {
                            passingCarChars.Dequeue();
                            if (passingCarChars.Count ==0 )
                            {
                                totalCarsPassed++;
                            }
                        }
                    }

                    if (passingCarChars.Count > 0)
                    {
                        Console.WriteLine("A crash happened!");
                        Console.WriteLine($"{currCar} was hit at {passingCarChars.Peek()}.");
                        return;
                    }
                }
                else
                {
                    queuedCars.Enqueue(token);
                }



            }
            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{totalCarsPassed} total cars passed the crossroads.");
        }
    }
}
