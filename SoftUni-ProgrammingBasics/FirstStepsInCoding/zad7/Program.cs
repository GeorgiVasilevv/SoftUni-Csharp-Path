using System;

namespace zad7
{
    class Program
    {
        static void Main(string[] args)
        {
            int pileshki = int.Parse(Console.ReadLine());
            int riba = int.Parse(Console.ReadLine());
            int vegan = int.Parse(Console.ReadLine());

            double pilmenu = pileshki * 10.35;
            double ribamenu= riba * 12.40;
            double veganmenu = vegan * 8.15;
            double obshtasum = pilmenu + ribamenu + veganmenu;
            double desert = 0.20 * obshtasum;
            double dostafka = 2.50;
            double obshto = obshtasum + desert + dostafka;
            Console.WriteLine(obshto);




        }
    }
}
