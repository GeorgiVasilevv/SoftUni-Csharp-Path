using System;

namespace expercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            double vacation = double.Parse(Console.ReadLine());
            int puzells = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int teddyBears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());
            int toysSum = puzells + dolls + teddyBears + minions + trucks;
            double disscount = 0.0;
            double rent = 0.0;
            double leftSum = 0.0;
            double puzellsSum = puzells * 2.60;
            double dollsSum = dolls * 3;
            double teddyBearsSum = teddyBears * 4.10;
            double minionsSum = minions * 8.20;
            double trucksSum = trucks * 2;
            double priceSum = puzellsSum + dollsSum + teddyBearsSum + minionsSum + trucksSum;
            if (toysSum >= 50)
            {
                disscount = priceSum * 0.25;
            }
            priceSum -= disscount;
            rent = priceSum * 0.10;
            leftSum = priceSum - rent;

            double difference = leftSum - vacation;
            if (difference >= 0)
            {
                
                Console.WriteLine($"Yes! {difference:f2} lv left.");
            }
            else
            {
               
                difference = Math.Abs(difference);
                Console.WriteLine($"Not enough money! {difference:f2} lv needed.");
            }
        }
    }
}
