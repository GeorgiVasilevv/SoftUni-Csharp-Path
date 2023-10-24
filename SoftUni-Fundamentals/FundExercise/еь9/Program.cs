using System;

namespace еь9
{
    class Program
    {
        static void Main(string[] args)
        {
            float moneyAvaivable = float.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            float priceOfSabers = float.Parse(Console.ReadLine());
            float priceOfRobes = float.Parse(Console.ReadLine());
            float priceOfBelts = float.Parse(Console.ReadLine());
            float SUM = 0;
            SUM = priceOfSabers * (studentsCount +((float)Math.Ceiling(studentsCount *(float)0.10))) + priceOfRobes * studentsCount + priceOfBelts * (studentsCount - (studentsCount / 6));

            if (moneyAvaivable>=SUM)
            {
                Console.WriteLine($"The money is enough - it would cost {SUM:f2}lv.");
            }
            else if (SUM>moneyAvaivable)
            {
                Math.Abs(SUM -= moneyAvaivable);
                Console.WriteLine($"John will need {SUM:f2}lv more.");
            }
        }
    }
}
