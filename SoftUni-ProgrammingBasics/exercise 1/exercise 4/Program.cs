using System;

namespace exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int buget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishers = int.Parse(Console.ReadLine());

            double price = 0;

            if (season== "Spring")
            {
                price = 3000;
            }
            else if (season == "Summer" || season == "Autumn")
            {
                price = 4200;
            }
            else if (season == "Winter")
            {
                price = 2600;
            }
            if (fishers<=6)
            {
                price = price - (price * 0.1);
            }
            else if (fishers>=7 && fishers<=11)
            {
                price = price - (price * 0.15);
            }
            else if (fishers > 12)
            {
                price = price - (price * 0.25);
            }
            if (fishers%2==0 && season != "Autumn")
            {
                price= price - (price * 0.05);
            }

            double difference = buget - price;
            if (buget>=price)
            {
                Console.WriteLine($"Yes! You have {difference:f2} leva left.");
            }
            else if (price>buget)
            {
                difference = Math.Abs(difference);
                Console.WriteLine($"Not enough money! You need {difference:f2} leva.");
            }
        }
    }
}
