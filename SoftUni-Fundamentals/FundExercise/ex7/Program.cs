using System;

namespace ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            string change = Console.ReadLine();
            double sum = 0;
            double nuts = 2.0, water = 0.7, crisps = 1.5, soda = 0.8, coke = 1;
            while (change != "Start")
            {

                if (double.Parse(change) == 0.1 || double.Parse(change) == 0.2 || double.Parse(change) == 0.5 || double.Parse(change) == 1 || double.Parse(change) == 2)
                {
                    sum += double.Parse(change);
                }
                else
                {
                    Console.WriteLine($"Cannot accept {double.Parse(change)}");
                }
                change = Console.ReadLine();
            }
            string products = Console.ReadLine();
            while (products != "End")
            {
                if (products == "Nuts")
                {
                    if (sum-nuts>=0)
                    {
                        Console.WriteLine($"Purchased nuts" );
                        sum -= nuts;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (products == "Water")
                {
                    if (sum - water >= 0)
                    {
                        Console.WriteLine($"Purchased water");
                        sum -= water;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (products == "Crisps")
                {
                    if (sum - crisps >= 0)
                    {
                        Console.WriteLine($"Purchased crisps");
                        sum -= crisps;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (products == "Soda")
                {
                    if (sum - soda >= 0)
                    {
                        Console.WriteLine($"Purchased soda");
                        sum -= soda;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (products == "Coke")
                {
                    if (sum - coke >= 0)
                    {
                        Console.WriteLine($"Purchased coke");
                        sum -= coke;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }
                products = Console.ReadLine();
            }
            Console.WriteLine($"Change: {sum:f2}");

        }
    }
}
