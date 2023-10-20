using System;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int photos = int.Parse(Console.ReadLine());
            int scenes = int.Parse(Console.ReadLine());
            int sceneTime = int.Parse(Console.ReadLine());

            double terain = photos * 0.15;
            int scenesSum = scenes * sceneTime;
            double allTime = Math.Round(terain + scenesSum);
            if (photos>allTime)
            {
                Console.WriteLine($"You managed to finish the movie on time! You have {Math.Abs(photos-allTime)} minutes left!");
            }
            else
            {
                Console.WriteLine($"Time is up! To complete the movie you need {Math.Abs(photos - allTime)} minutes.");
            }
        }
    }
}
