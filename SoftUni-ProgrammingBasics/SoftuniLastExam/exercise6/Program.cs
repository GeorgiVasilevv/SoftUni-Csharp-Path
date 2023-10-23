using System;

namespace exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            int locations = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < locations; i++)
            {
                double SUM = 0;
                double avargeGold = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                for (int k = 0; k < days; k++)
                {
                    double goldGained = double.Parse(Console.ReadLine());
                    SUM += goldGained;
                }
                double SumGold = SUM/days;
                if (SumGold>= avargeGold)
                {
                    Console.WriteLine($"Good job! Average gold per day: {SumGold:f2}.");
                }
                else
                {
                    Console.WriteLine($"You need {Math.Abs(SumGold-avargeGold):f2} gold.");
                }
            }
        }
    }
}
