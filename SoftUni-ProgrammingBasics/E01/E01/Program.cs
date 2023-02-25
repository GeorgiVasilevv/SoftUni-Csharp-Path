using System;

namespace E01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int numberOfCities = int.Parse(Console.ReadLine());
            //double totalProfit = 0;
            //double profitPerCity = 0;
            //double lostMoney = 0;
            //for (int i = 1; i <= numberOfCities; i++)
            //{
            //    string nameOfCity = Console.ReadLine();
            //    double ownerIncome = double.Parse(Console.ReadLine());
            //    double ownerExpenses = double.Parse(Console.ReadLine());

            //    if (i%3==0 || i%5!=0)
            //    {
            //        ownerExpenses += ownerExpenses * 0.50;
            //    }

            //    if (i % 5 == 0)
            //    {

            //        lostMoney -= ownerIncome * 0.10;//
            //        profitPerCity = ownerIncome - (lostMoney + ownerExpenses);

            //    }
            //    else
            //    {
            //    profitPerCity = ownerIncome - ownerExpenses;

            //    }
            //    Console.WriteLine($"In {nameOfCity} Burger Bus earned {profitPerCity:f2} leva.");
            //    totalProfit += profitPerCity;
            //}
            //Console.WriteLine($"Burger Bus total profit: {totalProfit} leva.");

            int citiesNumber = int.Parse(Console.ReadLine());

            decimal lostMoney = 0;
            decimal profitPerCity = 0;
            decimal totalProfit = 0;

            for (int i = 1; i <= citiesNumber; i++)
            {
                string cityName = Console.ReadLine();
                decimal income = decimal.Parse(Console.ReadLine());
                decimal expenses = decimal.Parse(Console.ReadLine());

                if (i %3== 0 && i%5!=0)
                {
                    expenses = expenses + expenses * 0.5m;
                }

                if (i %5== 0)
                {
                    lostMoney = income * 0.1m;
                    profitPerCity = income - (lostMoney + expenses);
                }
                else
                {
                    profitPerCity = income - expenses;
                }

                totalProfit += profitPerCity;

                Console.WriteLine($"In {cityName} Burger Bus earned {profitPerCity:f2} leva.");

            }
            Console.WriteLine($"Burger Bus total profit: {totalProfit:f2} leva.");
        }
    }
    
}
