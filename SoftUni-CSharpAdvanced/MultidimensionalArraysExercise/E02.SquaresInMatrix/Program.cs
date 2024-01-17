using System;

namespace E02.SquaresInMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] dimentions = Console.ReadLine().Split();
            int rows = int.Parse(dimentions[0]);
            int cols = int.Parse(dimentions[1]);

            char[,] matrix = new char[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string[] input = Console.ReadLine().Split();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = char.Parse(input[col]);
                }
            }

            int squareMatrixCounter = 0;

            for (int row = 0; row < rows - 1; row++)
            {
                for (int col = 0; col < cols - 1; col++)
                {
                    if (matrix[row, col] == matrix[row, col + 1]
                        && matrix[row, col] == matrix[row + 1, col]
                        && matrix[row, col] == matrix[row + 1, col + 1])
                    {
                        squareMatrixCounter++;
                    }
                }
            }
            Console.WriteLine(squareMatrixCounter);
        }
    }
}
