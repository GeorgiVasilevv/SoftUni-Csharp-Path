using System;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();
            string date = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            double sum = 0;

            if (country=="France")
            {
                if (date=="21-23")
                {
                    sum = days * 30;
                }
                else if (date=="24-27")
                {
                    sum = days * 35;
                }
                else if (date=="28-31")
                {
                    sum = days * 40;
                }
            }
            else if (country== "Italy")
            {
                if (date == "21-23")
                {
                    sum = days * 28;
                }
                else if (date == "24-27")
                {
                    sum = days * 32;
                }
                else if (date == "28-31")
                {
                    sum = days * 39;
                }
            }
            else if (country=="Germany")
            {
                if (date == "21-23")
                {
                    sum = days * 32;
                }
                else if (date == "24-27")
                {
                    sum = days * 37;
                }
                else if (date == "28-31")
                {
                    sum = days * 43;
                }
            }
            Console.WriteLine($"Easter trip to {country} : {sum:f2} leva.");
        }
    }
}
