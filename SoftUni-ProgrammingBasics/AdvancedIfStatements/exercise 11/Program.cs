using System;

namespace exercise_11
{
    class Program
    {
        static void Main(string[] args)
        {
            string item = Console.ReadLine();
            string day = Console.ReadLine();
            double amount = double.Parse(Console.ReadLine());
            double price = 0;
            if (day == "Monday" ||
                day == "Tuesday" ||
                day == "Wednesday" ||
                day == "Thursday" ||
                day == "Friday")
            {
                if (item == "banana")
                {
                    price = 2.50;
                }
                else if (item == "apple")
                {
                    price = 1.20;
                }
                else if (item == "orange")
                {
                    price = 0.85;
                }
                else if (item == "grapefruit")
                {
                    price = 1.45;
                }
                else if (item == "kiwi")
                {
                    price = 2.70;
                }
                else if (item == "pineapple")
                {
                    price = 5.50;
                }
                else if (item == "grapes")
                {
                    price = 3.85;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }

            else if (day == "Saturday" ||
                day == "Sunday")
            {
                if (item == "banana")
                {
                    price = 2.70;
                }
                else if (item == "apple")
                {
                    price = 1.25;
                }
                else if (item == "orange")
                {
                    price = 0.90;
                }
                else if (item == "grapefruit")
                {
                    price = 1.60;
                }
                else if (item == "kiwi")
                {
                    price = 3.00;
                }
                else if (item == "pineapple")
                {
                    price = 5.60;
                }
                else if (item == "grapes")
                {
                    price = 4.20;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }


            double sum = price * amount;

            if (sum != 0)
            {
                Console.WriteLine($"{sum:f2}");
            }

        }





    }

}

