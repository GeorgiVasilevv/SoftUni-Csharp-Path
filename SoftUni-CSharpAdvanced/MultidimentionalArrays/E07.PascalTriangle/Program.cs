using System;

namespace E07.PascalTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            long[][] pascal = new long[n][];

            for (int row = 0; row < n; row++)
            {
                pascal[row] = new long[row+1];
                for (int col = 0; col < pascal[row].Length; col++)
                {
                    if (row==0)
                    {
                        pascal[row][col] = 1;
                        continue;
                    }

                    long currValue = 0; 

                    if (col > 0 && row > 0)
                    {
                        currValue += pascal[row - 1][col - 1];
                    }

                    if (col < pascal[row].Length -1 )
                    {
                        currValue += pascal[row - 1][col];
                    }

                    pascal[row][col] = currValue;
                }
            }

            for (int i = 0; i < pascal.Length; i++)
            {
                for (int j = 0; j < pascal[i].Length; j++)
                {
                    Console.Write(pascal[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
