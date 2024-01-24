using System;
using System.Collections.Generic;
using System.Linq;

namespace E04.ProductShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> stores = new Dictionary<string, Dictionary<string, double>>();

            string command = Console.ReadLine();
            while (command != "Revision")
            {

                string[] input = command.Split(", ");
                string shop = input[0];
                string product = input[1];
                double price = double.Parse(input[2]);

                if (!stores.ContainsKey(shop))
                {
                    stores.Add(shop, new Dictionary<string, double>());
                }

                stores[shop].Add(product, price);

                command = Console.ReadLine();
            }

            stores = stores.OrderBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var store in stores)
            {
                Console.WriteLine($"{store.Key}->");
                foreach (var info in store.Value)
                {
                    Console.WriteLine($"Product: {info.Key}, Price: {info.Value}");
                }
            }
        }
    }
}
