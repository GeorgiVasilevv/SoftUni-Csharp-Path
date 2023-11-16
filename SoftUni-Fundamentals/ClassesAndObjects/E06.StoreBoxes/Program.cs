using System;
using System.Collections.Generic;
using System.Linq;

namespace E06.StoreBoxes
{
    class Item
    {
        public Item(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }
        public string Name { get; set; }
        public double Price { get; set; }
    }

    class Box
    {
        public Box(string serialNumber, Item item, int quantity, double priceForABox)
        {
            this.SerialNumber = serialNumber;
            this.Item = item;
            this.Quantity = quantity;
            this.PriceForABox = priceForABox;
        }

        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int Quantity { get; set; }
        public double PriceForABox { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Box> items = new List<Box>();

            string cmd = Console.ReadLine();
            while (cmd != "end")
            {
                string[] tokens = cmd.Split(" ",StringSplitOptions.RemoveEmptyEntries);

                string serialNumber=tokens[0];
                string item=tokens[1];
                int quantity = int.Parse(tokens[2]);
                double itemPrice = double.Parse(tokens[3]);
                double priceForABox = quantity * itemPrice;

                Item item1 = new Item(item, itemPrice);
                Box box = new Box(serialNumber, item1, quantity,priceForABox);

                items.Add(box);

                cmd = Console.ReadLine();
            }
            List<Box> sortedBoxer = items.OrderByDescending(boxes => boxes.PriceForABox).ToList();

            foreach (Box box in sortedBoxer)
            {
                
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.Quantity}");
                Console.WriteLine($"-- ${box.PriceForABox:F2}");
            }
        }
    }
}
