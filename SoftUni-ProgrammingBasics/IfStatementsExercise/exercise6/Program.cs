using System;

namespace exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double time = double.Parse(Console.ReadLine());

            double swimDistance = distance * time;
            double timeAdded = distance / 15;
            timeAdded = Math.Floor(timeAdded);
            timeAdded *= 12.5;

            double recordIvan = distance * time + timeAdded;
            if (recordIvan<record)
            {
                
                Console.WriteLine($" Yes, he succeeded! The new world record is {recordIvan:f2} seconds.");
            }
            else
            {
                double difference = recordIvan - record;
                Console.WriteLine($"No, he failed! He was {difference:f2} seconds slower.");
            }
        }
    }
}
