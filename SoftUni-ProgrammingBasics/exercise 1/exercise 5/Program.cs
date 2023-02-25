using System;

namespace exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double buget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string destination = "";
            string typeDestination = "";
            
            if (buget<=100)
            {
                destination = "Somewhere in Bulgaria";
                if (season=="summer")
                {
                    buget *= 0.3;
                    typeDestination = "Camp";
                }
                else if (season=="winter")
                {
                    buget *= 0.7;
                    typeDestination = "Hotel";
                }
            }
            else if (buget<=1000)
            {
                destination = "Somewhere in Balkans";
                if (season == "summer")
                {
                    buget *= 0.4;
                    typeDestination = "Camp";
                }
                else if (season == "winter")
                {
                    buget *= 0.8;
                    typeDestination = "Hotel";
                }
            }
            else if (buget>=1000)
            {
                typeDestination = "Hotel";
                destination = "Somewhere in Europe";
                buget *= 0.9;
            }
            Console.WriteLine(destination);
            Console.WriteLine(typeDestination +  " - " + $"{buget:f2}");
        }
    }
}
