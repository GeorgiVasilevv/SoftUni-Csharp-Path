using System;
using System.Collections.Generic;
using System.Linq;

namespace E04.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> orders = new Dictionary<string, List<double>>();
            string cmd = Console.ReadLine();
            while (cmd!="buy")
            {
                string[] tokens = cmd.Split(' ').ToArray();
                string name = tokens[0];
                double price = double.Parse(tokens[1]);
                int quantity = int.Parse(tokens[2]);
                if (orders.ContainsKey(name))
                {
                    orders[name][0] = price;
                    orders[name][1] += quantity;
                }
                else
                {
                    orders.Add(name,new List<double>() { price, quantity });
                }
                cmd = Console.ReadLine();
            }
            foreach (var item in orders)
            {
                Console.WriteLine($"{item.Key} -> {(item.Value[0] * item.Value[1]):f2}");
            }
        }
    }
}
