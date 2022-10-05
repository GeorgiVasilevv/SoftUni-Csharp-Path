using System;

namespace exercise_12
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double amount = double.Parse(Console.ReadLine());
            bool isTrue = true;
            if (town == "Sofia")
            {
                if (amount >= 0 && amount <= 500)
                {
                    amount = amount * 0.05;
                }
                else if (amount >= 500 && amount <= 1000)
                {
                    amount = amount * 0.07;
                }
                else if (amount >= 1000 && amount <= 10000)
                {
                    amount = amount * 0.08;
                }
                else if (amount >= 10000 )
                {
                    amount = amount * 0.12;
                }
                else
                {
                    Console.WriteLine("error");
                }

            }
            else if (town=="Varna")
            {
                if (amount >= 0 && amount <= 500)
                {
                    amount = amount * 0.045;
                }
                else if (amount >= 500 && amount <= 1000)
                {
                    amount = amount * 0.075;
                }
                else if (amount >= 1000 && amount <= 10000)
                {
                    amount = amount * 0.10;
                }
                else if (amount >= 10000)
                {
                    amount = amount * 0.13;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (town=="Plovdiv")
            {
                if (amount >= 0 && amount <= 500)
                {
                    amount = amount * 0.055;
                }
                else if (amount >= 500 && amount <= 1000)
                {
                    amount = amount * 0.08;
                }
                else if (amount >= 1000 && amount <= 10000)
                {
                    amount = amount * 0.12;
                }
                else if (amount >= 10000)
                {
                    amount = amount * 0.145;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
                isTrue = false;
            }
            if (amount >= 0 && isTrue ==true)
            {
                Console.WriteLine($"{amount:f2}");
            }
        }
    }
}
