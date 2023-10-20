using System;

namespace ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            string playerName = Console.ReadLine();
            string targetHit = Console.ReadLine();
            int gamePoints = 301;
            int successGames = 0;
            int unsuccessGames = 0;
            while (targetHit != "Retire" )
            {
                
                int points = int.Parse(Console.ReadLine());

                int totalCurrentPoints = 0;

                if (targetHit == "Single")
                {
                    totalCurrentPoints = points;
                }
                else if (targetHit == "Double")
                {
                    totalCurrentPoints = points* 2;
                }
                else if (targetHit == "Triple")
                {
                    totalCurrentPoints = points *3;
                }

                if (gamePoints>=totalCurrentPoints)
                {
                    gamePoints -= totalCurrentPoints;
                    successGames++;
                }
                else
                {
                    unsuccessGames++;
                }

                if (gamePoints == 0)
                {
                    Console.WriteLine($"{playerName} won the leg with {successGames} shots.");
                    break;
                }


                targetHit = Console.ReadLine();
            }
            if (targetHit=="Retire")
            {
                Console.WriteLine($"{playerName} retired after {unsuccessGames} unsuccessful shots.");
            }
            
        }
    }
}
