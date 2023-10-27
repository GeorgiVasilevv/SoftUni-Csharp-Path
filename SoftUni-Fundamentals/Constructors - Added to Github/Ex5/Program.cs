using System;
using System.Linq;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] topIntegers = new int[arr.Length];
            int topIntegersCounter = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int currentNum = arr[i];
                bool isBigger = true;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (currentNum <= arr[j])
                    {
                        isBigger = false;
                        break;
                    }



                }
                if (isBigger)
                {
                    topIntegers[topIntegersCounter++] = currentNum;
                }
            }
            for (int i = 0; i < topIntegersCounter; i++)
            {
                Console.Write(topIntegers[i] + " ");
            }
        }
    }
}
