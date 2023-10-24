using System;

namespace ex11
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double orderPrice = 0;
            double total = 0;
            for (int i = 0; i < n; i++)
            {
                double pricePerCapsule = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsulesCount = int.Parse(Console.ReadLine());
                orderPrice = pricePerCapsule * days * capsulesCount;
                Console.WriteLine($"The price for the coffee is: ${orderPrice:f2}");
                total += orderPrice;
            }
            Console.WriteLine($"Total: ${total:f2}");
        }
    }
}
