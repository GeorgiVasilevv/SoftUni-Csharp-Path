using System;
using System.Linq;

namespace E02.SumMatrixColumns
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] arrayArgs = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = arrayArgs[0];
            int columns = arrayArgs[1];
            int[,] matrix = new int[rows, columns];
            for (int row = 0; row < rows; row++)
            {
                string[] colData = Console.ReadLine().Split(" ");

                for (int col = 0; col < columns; col++)
                {
                    matrix[row, col] = int.Parse(colData[col]);
                }
            }

            for (int col = 0; col < columns; col++)
            {
                int sum = 0;
                for (int row = 0; row < rows; row++)
                {
                    sum += matrix[row,col];
                }
                Console.WriteLine(sum);
            }
            
        }
    }
}
