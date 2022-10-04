using System;

namespace IfStatementsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstTime = int.Parse(Console.ReadLine());
            int secoundTime = int.Parse(Console.ReadLine());
            int thirdTime = int.Parse(Console.ReadLine());


            int sumTime = firstTime + secoundTime + thirdTime;

            int minutes = sumTime / 60;
            int secounds = sumTime % 60;

            if(secounds < 10)
            {
                Console.WriteLine($"{minutes}:0{secounds} ");
            }
            else
            {
                Console.WriteLine($"{minutes}:{secounds}");
            }
        }
    }
}
