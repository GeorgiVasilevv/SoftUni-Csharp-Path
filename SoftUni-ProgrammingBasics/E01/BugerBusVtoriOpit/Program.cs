using System;

namespace BugerBusVtoriOpit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCities = int.Parse(Console.ReadLine());
            double totalProfit = 0;
            for (int i = 1; i <= numberOfCities; i++)
            {
                string nameOfCity = Console.ReadLine();
                double ownerIncome = double.Parse(Console.ReadLine());
                double ownerExpenses = double.Parse(Console.ReadLine());

                if (i % 3 == 0)
                {
                    ownerExpenses += ownerExpenses * 0.50;
                }
                if (i%5==0)
                {
                    ownerIncome -= ownerIncome * 0.10;
                }

                Console.WriteLine($"In {nameOfCity} Burger Bus earned {ownerIncome-ownerExpenses:f2} leva.");
                totalProfit += ownerIncome - ownerExpenses;
            }
            Console.WriteLine($"Burger Bus total profit: {totalProfit:F2} leva.");

        }
    }
}
