using System;

namespace SoftuniLastExam
{
    class Program
    {
        static void Main(string[] args)
        {
            double speed = double.Parse(Console.ReadLine());
            double fuel = double.Parse(Console.ReadLine());
            double road = 384400 * 2;
            double timeForthAndBack = Math.Ceiling(road / speed);
            double sumTime = timeForthAndBack + 3;
            Console.WriteLine(sumTime);
            double sumFuel = (fuel * road) / 100;
            Console.WriteLine(sumFuel);

        }
    }
}
