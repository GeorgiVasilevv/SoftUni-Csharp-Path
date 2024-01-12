using System;
using System.Linq;

namespace E03.PrimaryDiagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] array = new int[n, n];

            for (int r = 0; r < n; r++)
            {
                int[] colData = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int c = 0; c < n; c++)
                {
                    array[r, c] = colData[c];
                }
            }

            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += array[i, i];
            }
            Console.WriteLine(sum);
        }
    }
}
