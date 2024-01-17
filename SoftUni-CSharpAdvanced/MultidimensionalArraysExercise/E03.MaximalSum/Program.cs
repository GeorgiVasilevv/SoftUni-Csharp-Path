using System;

namespace E03.MaximalSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] dimentions = Console.ReadLine().Split();
            int rows = int.Parse(dimentions[0]);
            int cols = int.Parse(dimentions[1]);

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string[] input = Console.ReadLine().Split();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = int.Parse(input[col]);
                }
            }

            int maxSum = int.MinValue;
            int maxRow = 0;
            int maxCol = 0;


            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    int currSum =
                        matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                         matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                    if (currSum>maxSum)
                    {
                        maxSum = currSum;
                        maxCol = col;
                        maxRow = row;
                    }
                }
            }
            Console.WriteLine($"Sum = {maxSum}");
            for (int row = maxRow; row < maxRow+3; row++)
            {
                for (int col = maxCol; col < maxCol+3; col++)
                {
                    Console.Write(matrix[row,col] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
