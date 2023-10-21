using System;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            double packageWeight = double.Parse(Console.ReadLine());
            string typeOfDelivery = Console.ReadLine();
            int distance = int.Parse(Console.ReadLine());
            double price = 0;

            if (typeOfDelivery== "standard")
            {
                if (packageWeight<1)
                {
                    price=distance * 0.03;
                }
                else if (packageWeight > 1 && packageWeight < 10)
                {
                    price = distance * 0.05;
                }
                else if (packageWeight >= 10 && packageWeight < 40)
                {
                    price = distance * 0.10;
                }
                else if (packageWeight >= 40 && packageWeight < 90)
                {
                    price = distance * 0.15;
                }
                else if (packageWeight >= 90 && packageWeight < 150)
                {
                    price = distance * 0.20;
                }
            }
            else if (typeOfDelivery == "express")
            {
                double nadcenka = 0;
                double sumNadcenka = 0;
                if (packageWeight < 1)
                {
                    price = distance * 0.03;
                    nadcenka = 0.8 * 0.03;
                    
                }
                else if (packageWeight > 1 && packageWeight < 10)
                {
                    price = distance * 0.05;
                    nadcenka = 0.4 * 0.05;
                }
                else if (packageWeight >= 10 && packageWeight < 40)
                {
                    price = distance * 0.10;
                    nadcenka = 0.05 * 0.10;
                }
                else if (packageWeight >= 40 && packageWeight < 90)
                {
                    price = distance * 0.15;
                    nadcenka = 0.02 * 0.15;
                }
                else if (packageWeight >= 90 && packageWeight < 150)
                {
                    price = distance * 0.20;
                    nadcenka = 0.01 * 0.20;
                }
                nadcenka = nadcenka * packageWeight;
                sumNadcenka = nadcenka * distance;
                price = price + sumNadcenka;
            }
            Console.WriteLine($"The delivery of your shipment with weight of {packageWeight:f3} kg. would cost {price:f2} lv.");
        }
    }
}
