using System;
using System.Linq;

namespace E06.Jagged_ArrayModification
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int dimentions = int.Parse(Console.ReadLine());

            int[,] matrix = new int[dimentions, dimentions];
            
            for (int row = 0; row < dimentions; row++)
            {
                int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int col = 0; col < dimentions; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            string command = Console.ReadLine();
            while (command != "END")
            {
                string[] input = command.Split();
                if (input[0] == "Add")
                {
                    int row = int.Parse(input[1]);
                    int col = int.Parse(input[2]);
                    int value = int.Parse(input[3]);

                    if (row>=0 && row < matrix.GetLength(0) && col >=0 && col < matrix.GetLength(1))
                    {
                        matrix[row, col] += value;
                    }
                    else
                    {
                        Console.WriteLine($"Invalid coordinates");
                    }
                }
                else if (input[0] == "Subtract")
                {

                    int row = int.Parse(input[1]);
                    int col = int.Parse(input[2]);
                    int value = int.Parse(input[3]);

                    if (row>=0 && row < matrix.GetLength(0) && col>=0 &&  col < matrix.GetLength(1))
                    {
                        matrix[row, col] -= value;
                    }
                    else
                    {
                        Console.WriteLine($"Invalid coordinates");
                    }
                }

                command = Console.ReadLine();
            }

            for (int row = 0; row < dimentions; row++)
            {
                for (int col = 0; col < dimentions; col++)
                {
                    Console.Write(matrix[row,col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
