using System;

namespace _08.BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal biggestKeg = decimal.MinValue;
            string biggestModel = string.Empty;
            for (int i = 0; i < n; i++)
            {
            string model = Console.ReadLine();
            decimal radius = decimal.Parse(Console.ReadLine());
            long height = long.Parse(Console.ReadLine());
                decimal currentKeg = (decimal)Math.PI * radius * radius * height;

                if (currentKeg>biggestKeg)
                {
                    biggestKeg = currentKeg;
                    biggestModel = model;
                }
            }
            Console.WriteLine(biggestModel);
                
        }
    }
}
