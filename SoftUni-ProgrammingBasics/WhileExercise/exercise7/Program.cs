using System;

namespace exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            int wightSpace = int.Parse(Console.ReadLine());
            int lengthSpace = int.Parse(Console.ReadLine());
            int heighSpace = int.Parse(Console.ReadLine());
            int cubicMetresCount = wightSpace * lengthSpace * heighSpace;
            int piecesSum = 0;
            while (cubicMetresCount >= piecesSum)
            {
                string piecesTaken = Console.ReadLine();
                if (piecesTaken == "Done")
                {
                    break;
                }
                piecesSum += int.Parse(piecesTaken);
            }
            if (cubicMetresCount >= piecesSum)
            {
                Console.WriteLine($"{cubicMetresCount - piecesSum} Cubic meters left.");
            }
            else
            {
                Console.WriteLine($"No more free space! You need {Math.Abs(cubicMetresCount - piecesSum)} Cubic meters more.");
            }


        }
    }
}
