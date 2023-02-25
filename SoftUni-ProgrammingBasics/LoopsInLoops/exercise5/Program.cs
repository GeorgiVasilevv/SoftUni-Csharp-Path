using System;

namespace exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            while (destination != "End")
            {

                double buget = double.Parse(Console.ReadLine());
                double sum = 0;
                while (sum < buget)
                {
                    sum += double.Parse(Console.ReadLine());
                }

                Console.WriteLine($"Going to {destination}!");

                destination = Console.ReadLine();
            }
        }
    }
}
