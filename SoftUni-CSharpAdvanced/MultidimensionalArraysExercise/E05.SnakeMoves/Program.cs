using System;

namespace E05.SnakeMoves
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] dimentions = Console.ReadLine().Split();
            int rows = int.Parse(dimentions[0]);
            int cols = int.Parse(dimentions[1]);

            char[,] matrix = new char[rows, cols];

            string word = Console.ReadLine();
            int currWordIndex = 0;

            for (int row = 0; row < rows; row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        if (currWordIndex == word.Length)
                        {
                            currWordIndex = 0;
                        }
                        matrix[row, col] = word[currWordIndex++];
                    }
                }
                else
                {
                    for (int col = cols - 1; col >= 0; col--)
                    {
                        if (currWordIndex == word.Length)
                        {
                            currWordIndex = 0;
                        }
                        matrix[row, col] = word[currWordIndex++];
                    }
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
