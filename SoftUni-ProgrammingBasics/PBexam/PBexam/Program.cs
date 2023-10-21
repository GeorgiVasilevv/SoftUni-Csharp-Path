using System;

namespace PBexam
{
    class Program
    {
        static void Main(string[] args)
        {
            double CPU = double.Parse(Console.ReadLine());
            double GPU = double.Parse(Console.ReadLine());
            double RAM = double.Parse(Console.ReadLine());
            int RAMnum = int.Parse(Console.ReadLine());
            double disscount = double.Parse(Console.ReadLine());

            CPU *= 1.57;
            GPU *= 1.57;
            RAM *= 1.57;
            RAM *= RAMnum;
            CPU = CPU - (CPU * disscount);
            GPU= GPU - (GPU * disscount);
            
            double sum = CPU + GPU + RAM;
            Console.WriteLine($"Money needed - {sum:f2} leva.");
        }
    }
}
