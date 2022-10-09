using System;

namespace exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double bankAccount = 0;

            while (input != "NoMoreMoney")
            {
                double sum = double.Parse(input);
                if (sum<0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                bankAccount += sum;
                Console.WriteLine($"Increase: {sum:f2}");
                input = Console.ReadLine();

            }
            Console.WriteLine($"Total: {bankAccount:f2}");
        }
    }
}
