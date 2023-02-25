using System;

namespace exercise_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string place = Console.ReadLine();
            string rating = Console.ReadLine();
            double sum = 9;
            days--;
            
            if (place== "room for one person")
            {
                sum = days * 18;
            }
            else if (place== "apartment")
            {
                sum = days * 25;
                if (days<10)
                {
                    sum = sum - (sum * 0.30);
                }
                else if (days>=10 && days<=15)
                {
                    sum = sum - (sum * 0.35);
                }
                else if (days >15)
                {
                    sum = sum - (sum * 0.50);
                }
            }
            else if (place == "president apartment")
            {
                sum = days * 35;
                if (days < 10)
                {
                    sum = sum - (sum * 0.10);
                }
                else if (days >= 10 && days <= 15)
                {
                    sum = sum - (sum * 0.15);
                }
                else if (days > 15)
                {
                    sum = sum - (sum * 0.20);
                }
            }
            if (rating == "positive")
            {
                sum = sum + (sum * 0.25);
                
            }
            else if (rating== "negative")
            {
                sum = sum - (sum * 0.10);
            }
            Console.WriteLine($"{sum:f2}");
        }
        
    }
}
