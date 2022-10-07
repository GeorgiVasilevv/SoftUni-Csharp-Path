using System;

namespace exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int points = int.Parse(Console.ReadLine());
            int pointsCountW = 0, pointsCountF = 0, pointsCountSF = 0;
            double percentCount = 0;
            for (int i = 0; i < n; i++)
            {
                string result = Console.ReadLine();

                if (result== "W")
                {
                    points = points + 2000;
                    pointsCountW = pointsCountW + 2000;
                    percentCount++;
                }
                else if (result== "F")
                {
                    points = points + 1200;
                    pointsCountF = pointsCountF + 1200;
                }
                else if (result== "SF")
                {
                    points = points + 720;
                    pointsCountSF = pointsCountSF + 720;
                }
            }
            double avargePoints= (pointsCountW+ pointsCountF+ pointsCountSF)/ n;
            avargePoints = Math.Floor(avargePoints);
            double percent = percentCount / n * 100;
            Console.WriteLine($"Final points: {points}");
            Console.WriteLine($"Average points: {avargePoints}");
            Console.WriteLine($"{percent:f2}%");
        }
    }
}
