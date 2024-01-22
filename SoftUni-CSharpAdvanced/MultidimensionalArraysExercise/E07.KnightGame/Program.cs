using System;

namespace E07.KnightGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dimentions = int.Parse(Console.ReadLine());
            char[,] chessboard = new char[dimentions, dimentions];

            for (int row = 0; row < dimentions; row++)
            {
                string chars = Console.ReadLine();
                for (int col = 0; col < dimentions; col++)
                {
                    chessboard[row, col] = chars[col];
                }
            }

            int knightsRemoved = 0;

            while (true)
            {
                int countMostAttacking = 0;
                int rowMostAttacking = 0;
                int colMostAttacking = 0;
                for (int row = 0; row < dimentions; row++)
                {

                    for (int col = 0; col < dimentions; col++)
                    {
                        if (chessboard[row, col] == 'K')
                        {
                            int attackedKnights = CountAttackedKnights(row, col, dimentions, chessboard);

                            if (attackedKnights > countMostAttacking)
                            {
                                countMostAttacking = attackedKnights;
                                rowMostAttacking = row;
                                colMostAttacking = col;

                            }
                        }
                    }

                }
                if (countMostAttacking == 0)
                {
                    Console.WriteLine(knightsRemoved);
                    break;
                }
                else
                {
                    chessboard[rowMostAttacking, colMostAttacking] = '0';
                    knightsRemoved++;
                }
            }

        }

        static int CountAttackedKnights(int row, int col, int dimentions, char[,] chessboard)
        {
            int attackedKnights = 0;

            if (IsValid(row + 2, col - 1, chessboard))
            {
                if (chessboard[row + 2, col - 1] == 'K')
                {
                    attackedKnights++;
                }
            }
            if (IsValid(row + 2, col + 1, chessboard))
            {
                if (chessboard[row + 2, col + 1] == 'K')
                {
                    attackedKnights++;
                }
            }
            if (IsValid(row - 2, col - 1, chessboard))
            {
                if (chessboard[row - 2, col - 1] == 'K')
                {
                    attackedKnights++;
                }
            }
            if (IsValid(row - 2, col + 1, chessboard))
            {
                if (chessboard[row - 2, col + 1] == 'K')
                {
                    attackedKnights++;
                }
            }
            if (IsValid(row + 1, col - 2, chessboard))
            {
                if (chessboard[row + 1, col - 2] == 'K')
                {
                    attackedKnights++;
                }
            }
            if (IsValid(row + 1, col + 2, chessboard))
            {
                if (chessboard[row + 1, col + 2] == 'K')
                {
                    attackedKnights++;
                }
            }
            if (IsValid(row - 1, col - 2, chessboard))
            {
                if (chessboard[row - 1, col - 2] == 'K')
                {
                    attackedKnights++;
                }
            }
            if (IsValid(row - 1, col + 2, chessboard))
            {
                if (chessboard[row - 1, col + 2] == 'K')
                {
                    attackedKnights++;
                }
            }

            return attackedKnights;
        }

        static bool IsValid(int row, int col, char[,] chessboard)
        {
            return row >= 0 && row < chessboard.GetLength(0)
            && col >= 0 && col < chessboard.GetLength(1);
        }
    }
}
