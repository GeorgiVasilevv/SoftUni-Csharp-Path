using System;

namespace exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string actorName = Console.ReadLine();
            double points = double.Parse(Console.ReadLine());
            int n =int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string ratingName = Console.ReadLine();
                double pointsName = double.Parse(Console.ReadLine());
                points = points + ((ratingName.Length * pointsName) / 2);
                if (points>1250.5)
                {
                    break;
                }
            }

            if (points>1250.5)
            {
                Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {points:f1}!");
            }
            else if (points < 1250.5)
            {
                double difference = Math.Abs(points - 1250.5);
                Console.WriteLine($"Sorry, {actorName} you need {difference:f1} more!");
            }
        }
    }
}
