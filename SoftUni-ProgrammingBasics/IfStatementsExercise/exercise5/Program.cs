using System;

namespace exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            double buget = double.Parse(Console.ReadLine());
            int statists = int.Parse(Console.ReadLine());
            double outfit = double.Parse(Console.ReadLine());
            double statistsOver = 0.0;
            double decor = buget * 0.10;
            double outfitPrice = statists * outfit;
            if (statists > 150)
            {
                statistsOver = outfitPrice * 0.10;
                outfitPrice = outfitPrice - statistsOver;
            }
            double sumMovie = decor + outfitPrice;
            double difference = buget - sumMovie;

            if (difference >= 0)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {difference:f2} leva left.");
            }
            else
            {
                difference = Math.Abs(difference);
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {difference:f2} leva more.");
            }
        }
    }
}
