using System;
using System.Linq;

namespace E01SumMatrixElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayArgs = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = arrayArgs[0];
            int columns = arrayArgs[1];
            int[,] matrix = new int[rows, columns];
            int sum = 0;
            for (int row = 0; row < rows; row++)
            {
                string[] rowData = Console.ReadLine().Split(", ");
                for (int col = 0; col < columns; col++)
                {
                    matrix[row,col] = int.Parse(rowData[col]);
                    sum += matrix[row,col];
                }
            }
            Console.WriteLine(rows);
            Console.WriteLine(columns);
            Console.WriteLine(sum);
        }
    }
}
