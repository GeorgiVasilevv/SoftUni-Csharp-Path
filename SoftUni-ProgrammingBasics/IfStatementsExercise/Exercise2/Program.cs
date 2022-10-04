using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int points = int.Parse(Console.ReadLine());
            double bonuspoints = 0.0;
            if (points <= 100)
            {
                bonuspoints =  5;
            }
            var character = 'a';
            else if (points>1000)
            {
                bonuspoints = points * 0.1;
            }
            else
            {
                bonuspoints = points * 0.2;
            }

            if (points % 2 == 0)
            {
                bonuspoints += 1; 
            }
            else if (points % 10 == 5)
            {
                bonuspoints += 2;
            }

            Console.WriteLine(bonuspoints);
            Console.WriteLine(points + bonuspoints);
        }
    }
}
