using System;

namespace E05.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            double items = int.Parse(Console.ReadLine());
            calculateOrder(product, items);
        }
        static void calculateOrder(string product, double items)
        {
            switch (product)
            {
                case "coffee":
                    Console.WriteLine($"{1.5 * items:f2}");
                    break;
                case "water":
                    Console.WriteLine($"{1 * items:f2}");
                    break;
                case "coke":
                    Console.WriteLine($"{1.4 * items:f2}");
                    break;
                case "snacks":
                    Console.WriteLine($"{2 * items:f2}");
                    break;



                default:
                    break;
            }
        }
    }
}
