using System;

namespace zad9
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double aqariumCapacity = length * width * height;
            double capacityInLitres = aqariumCapacity / 1000;
            double usedSpace = percent / 100;
            double neededLitres = capacityInLitres * (1 - usedSpace);

            Console.WriteLine(neededLitres);
        }
    }
}
