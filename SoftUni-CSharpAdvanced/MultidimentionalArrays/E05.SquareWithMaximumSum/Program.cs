using System;
using System.Linq;

namespace E05.SquareWithMaximumSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] dimentions = Console.ReadLine().Split(", ");
            int rows = int.Parse(dimentions[0]);
            int cols = int.Parse(dimentions[1]);

            int[,] matrix = new int[rows, cols];
            int biggestSum = int.MinValue;
            int biggestRowPos = 0;
            int biggestColumnPos = 0;
            for (int row = 0; row < rows; row++)
            {
                int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            for (int row = 0; row < rows-1; row++)
            {
                for (int col = 0; col < cols-1; col++)
                {
                    int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];

                    if (sum > biggestSum)
                    {
                        biggestSum = sum;
                        biggestRowPos = row;
                        biggestColumnPos = col;
                    }
                }
            }

            for (int i = biggestRowPos; i <= biggestRowPos+1; i++)
            {
                for (int j = biggestColumnPos; j <= biggestColumnPos+1; j++)
                {
                    Console.Write(matrix[i,j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(biggestSum);
        }
    }
}
