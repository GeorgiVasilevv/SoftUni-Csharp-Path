using System;

namespace exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowers = Console.ReadLine();
            double flowersCount = double.Parse(Console.ReadLine());
            double buget = double.Parse(Console.ReadLine());
            double price = 0;
            double totalprice = 0;

            if (flowers=="Roses")
            {
                price = 5;
                totalprice = flowersCount * price;
                
                if (flowersCount>80)
                {
                    totalprice *= 0.9;
                }

            }
            else if (flowers == "Dahlias")
            {
                price = 3.80;
                totalprice = flowersCount * price;
                if (flowersCount > 90)
                {
                    totalprice *= 0.85;
                }
            }
            else if (flowers == "Tulips")
            {
                price = 2.80;
                totalprice = flowersCount * price;
                if (flowersCount > 80)
                {
                    totalprice *= 0.85;
                }
            }
            else if (flowers == "Narcissus")
            {
                price = 3;
                totalprice = flowersCount * price;
                if (flowersCount < 120)
                {
                    totalprice *= 1.15;
                }
            }
            else if (flowers == "Gladiolus")
            {
                price = 2.50;
                totalprice = flowersCount * price;
                if (flowersCount < 80)
                {
                    totalprice *= 1.20;
                }
            }
            double difference = buget - totalprice;

            if (totalprice<=buget)
            {
                Console.WriteLine($"Hey, you have a great garden with {flowersCount} {flowers} and {difference:f2} leva left.");
            }
            else if(buget < totalprice)
            {
                difference = Math.Abs(difference);
                Console.WriteLine($"Not enough money, you need {difference:f2} leva more.");
            }
        }
    }
}
