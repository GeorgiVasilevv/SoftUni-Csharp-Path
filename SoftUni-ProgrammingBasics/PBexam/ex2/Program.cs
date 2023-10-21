using System;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysWithoutSanta = int.Parse(Console.ReadLine());
            int foodLeft = int.Parse(Console.ReadLine());
            double firstDeer = double.Parse(Console.ReadLine());
            double secondDeer = double.Parse(Console.ReadLine());
            double thirdDeer = double.Parse(Console.ReadLine());
            firstDeer = firstDeer * daysWithoutSanta;
            secondDeer = secondDeer * daysWithoutSanta;
            thirdDeer *= daysWithoutSanta;
            double sumFood = firstDeer + secondDeer + thirdDeer;

            if (sumFood<foodLeft)
            {
                double difference= foodLeft - sumFood;
                Console.WriteLine($"{Math.Floor( difference)} kilos of food left.");
            }
            else
            {
                double difference = Math.Abs(foodLeft - sumFood);
                Console.WriteLine($"{Math.Ceiling(difference)} more kilos of food are needed.");
            }


        }
    }
}
