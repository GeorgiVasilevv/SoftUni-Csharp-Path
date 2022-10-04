using System;

namespace exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            string serial = Console.ReadLine();
            int episode = int.Parse(Console.ReadLine());
            int LunchB = int.Parse(Console.ReadLine());

            double timeLunch = LunchB * 0.125;
            double timeRest = LunchB * 0.25;

            double timeLeft = LunchB - timeLunch - timeRest;

            if (timeLeft >=episode)
            {
                double timeLeftep = timeLeft - episode;
                timeLeftep = Math.Ceiling(timeLeftep);
                Console.WriteLine($"You have enough time to watch {serial} and left with {timeLeftep} minutes free time.");
            }
            else
            {
                double timeLeftep = timeLeft - episode;
                timeLeftep = Math.Abs(timeLeftep);
                timeLeftep = Math.Ceiling(timeLeftep);
                Console.WriteLine($"You don't have enough time to watch {serial}, you need {timeLeftep} more minutes.");
            }
        }
    }
}
