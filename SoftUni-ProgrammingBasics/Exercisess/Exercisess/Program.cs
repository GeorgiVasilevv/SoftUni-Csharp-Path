using System;

namespace Exercisess
{
    class Program
    {
        static void Main(string[] args)
        {
            int bitcoin = int.Parse(Console.ReadLine());
            double yuan = double.Parse(Console.ReadLine());
            double commisionRate = double.Parse(Console.ReadLine());
            double sum = 0;

            commisionRate = commisionRate / 100;
            bitcoin = bitcoin * 1168;
            yuan = yuan * 0.15;
            yuan = yuan * 1.76;
            sum = (bitcoin + yuan) / 1.95;

            Console.WriteLine($"{sum - (sum * commisionRate):f2}");

        }
    }
}
