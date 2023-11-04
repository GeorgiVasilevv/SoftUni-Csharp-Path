using System;
using System.Collections.Generic;
using System.Linq;

namespace E05.Bomb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int[] bomb = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int bombNumber = bomb[0];
            int bombPower = bomb[1];


            while (true)
            {
                int bombIndex = list.IndexOf(bombNumber);
                if (bombIndex==-1)
                {
                    break;
                }
                list=DetonateBomb(list, bombIndex, bombPower);
            }
            Console.WriteLine(list.Sum());

        }
        static List<int> DetonateBomb(List<int> list, int bombIndex, int bombPower)
        {
            int bombPowerIndexRight = bombIndex + bombPower;
            int bombPowerIndexLeft = bombIndex - bombPower;
            if (bombPowerIndexLeft < 0 )
            {
                bombPowerIndexLeft = 0;
            }
            for (int j = bombIndex; j <= bombPowerIndexRight; j++)
            {
                if (bombIndex >= list.Count)
                {
                    break;
                }
                list.RemoveAt(bombIndex);
            }
            for (int k = bombPowerIndexLeft; k < bombIndex; k++)
            {
                ////if (bombPowerIndexLeft >= list.Count)
                ////{
                ////    break;
                ////}
                list.RemoveAt(bombPowerIndexLeft);
            }
            return list;
        }
    }
}
