using System;

namespace exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenghtCake = int.Parse(Console.ReadLine());
            int wigthCake = int.Parse(Console.ReadLine());
            int cakePieces = lenghtCake * wigthCake;

            while (cakePieces >= 0)
            {
                string piecesTaken = Console.ReadLine();
                if (piecesTaken == "STOP")
                {
                    break;
                }
                cakePieces -= int.Parse(piecesTaken);


            }
            if (cakePieces >= 0)
            {
                Console.WriteLine($"{cakePieces} pieces are left.");
            }
            else
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(cakePieces)} pieces more.");
            }

        }
    }
}
