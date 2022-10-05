using System;

namespace exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string item = Console.ReadLine();
            string town = Console.ReadLine();
            double amount = double.Parse(Console.ReadLine());
            double price = 0;
            if (town == "Sofia")
            {
                if (item == "coffee")
                {
                    price = 0.50;
                }
                else if (item == "water")
                {
                    price = 0.80;
                }
                else if (item == "beer")
                {
                    price = 1.20;
                }
                else if (item == "sweets")
                {
                    price = 1.45;
                }
                else if (item == "peanuts")
                {
                    price = 1.60;
                }
            }
            else if (town=="Plovdiv")
            {
                if (item=="coffee")
                {
                    price = 0.40;
                }
                else if (item == "water")
                {
                    price = 0.70;
                }
                else if (item == "beer")
                {
                    price = 1.15;
                }
                else if (item == "sweets")
                {
                    price = 1.30;
                }
                else if (item == "peanuts")
                {
                    price = 1.50;
                }
            }
            else if (town=="Varna")
            {
                if (item=="coffee")
                {
                    price = 0.45;
                }
                else if (item == "water")
                {
                    price = 0.70;
                }
                else if (item == "beer")
                {
                    price = 1.10;
                }
                else if (item == "sweets")
                {
                    price = 1.35;
                }
                else if (item == "peanuts")
                {
                    price = 1.55;
                }
            }
            double sum = price * amount;
            Console.WriteLine(sum );
        }
    }
}
