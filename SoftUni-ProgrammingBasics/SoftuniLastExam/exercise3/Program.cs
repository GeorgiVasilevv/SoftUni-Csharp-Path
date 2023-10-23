using System;

namespace exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfCake = Console.ReadLine();
            int orderedCakes = int.Parse(Console.ReadLine());
            int dayOfDecember = int.Parse(Console.ReadLine());
            double SUM = 0;

            if (dayOfDecember<=15)
            {
                if (typeOfCake=="Cake")
                {
                    SUM = orderedCakes * 24;
                }
                else if (typeOfCake == "Souffle")
                {
                    SUM = orderedCakes * 6.66;
                }
                else if (typeOfCake == "Baklava")
                {
                    SUM = orderedCakes * 12.60;
                }
            }
            else if (dayOfDecember > 15)
            {
                if (typeOfCake == "Cake")
                {
                    SUM = orderedCakes * 28.70;
                }
                else if (typeOfCake == "Souffle")
                {
                    SUM = orderedCakes * 9.80;
                }
                else if (typeOfCake == "Baklava")
                {
                    SUM = orderedCakes * 16.98;
                }
            }
            if (dayOfDecember<=22)
            {
                if (SUM>=100 && SUM<=200)
                {
                    SUM = SUM * 0.85;
                }
                else if (SUM>200)
                {
                    SUM = SUM * 0.75;

                }
                if (dayOfDecember<=15)
                {
                    SUM = SUM * 0.90;
                }
            }
            Console.WriteLine($"{SUM:f2}");
        }
    }
}
