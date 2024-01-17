using System;

namespace E01.DiagonalDifference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dimentions = int.Parse(Console.ReadLine());
            int[,] matrix = new int[dimentions, dimentions];

            for (int row = 0; row < dimentions; row++)
            {
                string[] input = Console.ReadLine().Split();
                for (int col = 0; col < dimentions; col++)
                {
                    matrix[row, col] = int.Parse(input[col]);
                }
            }

            int leftSum = 0;
            int rightSum = 0;
            for (int i = 0, j = dimentions - 1; i < dimentions; i++, j--)
            {
                leftSum += matrix[i, i];
                rightSum += matrix[i, j];
            }
            Console.WriteLine(Math.Abs(leftSum-rightSum));

        }
    }
}
