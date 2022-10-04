using System;

namespace exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            double buget = double.Parse(Console.ReadLine());
            int GPU = int.Parse(Console.ReadLine());
            int CPU = int.Parse(Console.ReadLine());
            int RAM = int.Parse(Console.ReadLine());

            int GPUsum = GPU * 250;

            double CPUprice = GPUsum * 0.35;
            double CPUsum = CPUprice * CPU;

            double RAMprice = GPUsum * 0.10;
            double RAMsum = RAMprice * RAM;

            double sumAll = GPUsum + CPUsum + RAMsum;

            if (GPU > CPU)
            {
                sumAll = sumAll - 0.15 * sumAll;
            }
            if (buget >= sumAll)
            {
                double difference = buget - sumAll;
                Console.WriteLine($"You have {difference:f2} leva left!");
            }
            else
            {
                double difference = buget - sumAll;
                difference = Math.Abs(difference);
                Console.WriteLine($"Not enough money! You need {difference:f2} leva more!");
            }

        }
    }
}
