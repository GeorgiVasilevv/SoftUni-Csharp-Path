using System;

namespace E09.SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            int sum = 0;
            int daysWorked = 0;
            if (startingYield >= 100)
            {
            while (startingYield>=100)
            {
                sum +=startingYield- 26;
                startingYield -= 10;
                daysWorked++;
            }
            sum = sum - 26;
            Console.WriteLine(daysWorked);
            Console.WriteLine(sum);

            }
            else
            {
                Console.WriteLine(daysWorked);
                Console.WriteLine(sum);
            }
        }
    }
}
