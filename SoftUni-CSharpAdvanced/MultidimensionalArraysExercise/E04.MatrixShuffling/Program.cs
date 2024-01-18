using System;

namespace E04.MatrixShuffling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] dimentions = Console.ReadLine().Split();
            int rows = int.Parse(dimentions[0]);
            int cols = int.Parse(dimentions[1]);

            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string[] input = Console.ReadLine().Split();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            string command = Console.ReadLine();
            while (command != "END")
            {
                string[] tokens = command.Split();

                if (IsInputVailid(rows, cols, tokens))
                {
                    string temp = matrix[int.Parse(tokens[1]), int.Parse(tokens[2])];
                    matrix[int.Parse(tokens[1]), int.Parse(tokens[2])] = matrix[int.Parse(tokens[3]), int.Parse(tokens[4])];
                    matrix[int.Parse(tokens[3]), int.Parse(tokens[4])] = temp;
                    PrintMatrix(matrix);
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

                command = Console.ReadLine();

            }
            
        }
        static bool IsInputVailid(int rows, int cols, string[] tokens)
        {
            return tokens[0] == "swap"
                && tokens.Length == 5
                && int.Parse(tokens[1]) >= 0 && int.Parse(tokens[1]) < rows
                && int.Parse(tokens[2]) >= 0 && int.Parse(tokens[2]) < cols
                && int.Parse(tokens[3]) >= 0 && int.Parse(tokens[3]) < rows
                && int.Parse(tokens[4]) >= 0 && int.Parse(tokens[4]) < cols;
        }
        static void PrintMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
