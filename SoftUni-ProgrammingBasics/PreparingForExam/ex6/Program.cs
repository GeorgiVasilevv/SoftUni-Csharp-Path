using System;

namespace ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            int clients = int.Parse(Console.ReadLine());
            double totalSum = 0;
            for (int i = 0; i < clients; i++)
            {
                string item = Console.ReadLine();
                int itemCount = 0;
                double sum = 0;

                while (item != "Finish")
                {
                    if (item == "basket")
                    {
                        sum += 1.50;
                        itemCount++;
                    }
                    else if (item == "wreath")
                    {
                        sum += 3.80;
                        itemCount++;
                    }
                    else if (item == "chocolate bunny")
                    {
                        sum += 7;
                        itemCount++;
                    }
                    item = Console.ReadLine();
                }
                if (itemCount % 2 == 0)
                {
                    sum -= (sum * 0.20);
                    totalSum += sum;
                }
                else
                {
                    totalSum += sum;
                }
                Console.WriteLine($"You purchased {itemCount} items for {sum:f2} leva.");
            }
            Console.WriteLine($"Average bill per client is: {totalSum/clients:f2} leva.");
        }
    }
}
