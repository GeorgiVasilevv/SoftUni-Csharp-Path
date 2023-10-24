using System;

namespace ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double monitorPrice = double.Parse(Console.ReadLine());
            int headsetCount = 0;
            int mouseCount = 0;
            int keyboardCount = 0;
            int monitorCount = 0;

            headsetCount = lostGames / 2;
            mouseCount = lostGames / 3;
            keyboardCount = lostGames / 6;
            monitorCount = keyboardCount / 2;
            double sum = headsetCount * headsetPrice + mouseCount * mousePrice + keyboardCount * keyboardPrice + monitorCount * monitorPrice;
            Console.WriteLine($"Rage expenses: {sum:f2} lv.");
        }
    }
}
