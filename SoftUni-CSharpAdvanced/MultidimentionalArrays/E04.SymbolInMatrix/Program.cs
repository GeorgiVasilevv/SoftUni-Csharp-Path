using System;

namespace E04.SymbolInMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            for (int r = 0; r < n; r++)
            {
                string colData = Console.ReadLine();
                for (int c = 0; c < n; c++)
                {
                    matrix[r, c] = colData[c];
                }
            }
            char charToLook = char.Parse(Console.ReadLine());
            int AsciiChar = (int)charToLook;

            for (int r = 0; r < n; r++)
            {
                for (int c = 0; c < n; c++)
                {
                    if (matrix[r,c] ==AsciiChar)
                    {
                        Console.WriteLine($"({r}, {c})");
                        return;
                    }
                }
            }
            Console.WriteLine($"{charToLook} does not occur in the matrix");
        }
    }
}
