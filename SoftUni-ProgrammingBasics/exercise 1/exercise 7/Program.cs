using System;

namespace exercise_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double studio = 0;
            double apartament = 0;

            if (month == "October" || month == "May")
            {
                if (nights <= 7)
                {
                    studio = 50 * nights;
                    apartament = 65 * nights;
                }
                else if (nights > 7 && nights <= 14)
                {
                    studio = 50 - (50 * 0.05);
                    studio = studio * nights;
                    apartament = 65 * nights;
                }
                else if (nights > 14)
                {
                    studio = 50 - (50 * 0.30);
                    studio = studio * nights;
                    apartament = 65 - (65 * 0.10);
                    apartament = apartament * nights;
                }



            }

            else if (month == "June" || month == "September")
            {
                if (nights <= 14)
                {
                    studio = 75.20 * nights;
                    apartament = 68.70 * nights;
                }

                else if (nights > 14)
                {
                    studio = 75.20 - (75.20 * 0.20);
                    studio = studio * nights;
                    apartament = 68.70 - (68.70 * 0.10);
                    apartament = apartament * nights;
                }


            }
            else if (month == "July" || month == "August")
            {
                if (nights <= 14)
                {
                    studio = 76 * nights;
                    apartament = 77 * nights;
                }
                else if (nights > 14)
                {
                    apartament = 77 - (77 * 0.10);
                    apartament = apartament * nights;
                    studio = 76 * nights;
                }

            }
            Console.WriteLine($"Apartment: {apartament:f2} lv.");
            Console.WriteLine($"Studio: {studio:f2} lv.");
            
        }
    }
}

