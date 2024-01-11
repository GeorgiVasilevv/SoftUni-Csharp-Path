using System;
using System.Collections.Generic;
using System.Linq;

namespace E011.KeyRevolver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int priceOfBullet = int.Parse(Console.ReadLine());
            int barrelSize = int.Parse(Console.ReadLine());

            int usedBullets = 0;
            Stack<int> bullets = new Stack<int>(Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray());

            Queue<int> locks = new Queue<int>(Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray());

            int intelligence = int.Parse(Console.ReadLine());
            while (bullets.Any() && locks.Any())
            {
                StartShootingLocks(barrelSize, bullets, locks, ref usedBullets);
            }

            if (locks.Any())
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
            else
            {
                Console.WriteLine($"{bullets.Count} bullets left. Earned ${intelligence - (usedBullets * priceOfBullet)}");
            }
        }

        static void StartShootingLocks(int barrelSize, Stack<int> bullets, Queue<int> locks, ref int usedBullets)
        {

            int currBullet = bullets.Pop();
            int currLock = locks.Peek();
            usedBullets++;

            if (currBullet <= currLock)
            {
                locks.Dequeue();
                Console.WriteLine("Bang!");
            }
            else
            {
                Console.WriteLine("Ping!");
            }

            if (usedBullets % barrelSize == 0 && bullets.Count > 0)
            {
                Console.WriteLine("Reloading!");
            }

        }
    }
}
