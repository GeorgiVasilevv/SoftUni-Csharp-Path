using System;

namespace excercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            int lillyAge = int.Parse(Console.ReadLine());
            double washingMashine = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());
            int toy = 0;
            int money = 0;
            for (int i = 1; i <= lillyAge; i++)
            {
                if (i % 2 == 1)
                {
                    toy++;
                }
                else if (i % 2 == 0)
                {
                    money= money+ i*5;
                    money--;
                }

            }
            
            int soldToys = toy * toyPrice;
            int sum = money + soldToys;
            double leftMoney = Math.Abs(sum - washingMashine);
            if (sum>=washingMashine)
            {
                Console.WriteLine($"Yes! {leftMoney:f2}");
            }
            else if (washingMashine> sum)
            {
                Console.WriteLine($"No! {leftMoney:f2}");
            }
        }
    }
}
