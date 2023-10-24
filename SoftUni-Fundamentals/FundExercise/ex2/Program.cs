using System;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string day = Console.ReadLine();
            double priceOfTicket = 0;
            double SUM;
            if (day == "Friday")
            {
                if (typeOfGroup == "Students")
                {
                    priceOfTicket = 8.45;
                }
                else if (typeOfGroup == "Business")
                {
                    priceOfTicket = 10.9;
                }
                else if (typeOfGroup == "Regular")
                {
                    priceOfTicket = 15;
                }
            }
            else if (day == "Saturday")
            {
                if (typeOfGroup == "Students")
                {
                    priceOfTicket = 9.80;
                }
                else if (typeOfGroup == "Business")
                {
                    priceOfTicket = 15.6;
                }
                else if (typeOfGroup == "Regular")
                {
                    priceOfTicket = 20;
                }
            }
            else if (day == "Sunday")
            {
                if (typeOfGroup == "Students")
                {
                    priceOfTicket = 10.46;
                }
                else if (typeOfGroup == "Business")
                {
                    priceOfTicket = 16;
                }
                else if (typeOfGroup == "Regular")
                {
                    priceOfTicket = 22.5;
                }
            }
            if (typeOfGroup == "Business" && count >= 100)
            {

                count -= 10;
                SUM = priceOfTicket * count;
            }
            else
            {
                SUM = priceOfTicket * count;
            }

            if (typeOfGroup == "Students" && count >= 30)
            {


                SUM = SUM * 0.85;
            }


            if (typeOfGroup == "Regular" && count >= 10 && count <= 20)
            {
                SUM = priceOfTicket * count;

                SUM = SUM * 0.95;
            }


            Console.WriteLine($"Total price: {SUM:f2}");
        }
    }
}
