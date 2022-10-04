using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int afterMinutes = minutes + 15;
            int newAfterHours = afterMinutes / 60;
            int newAfterMinutes = afterMinutes % 60;
            int sumHours = 0;
            
            if (hours + newAfterHours < 24)
            {
                sumHours = hours + newAfterHours;
            }
            else
            {
                sumHours = (hours + newAfterHours) % 24  ;
               
            }

            if (newAfterMinutes < 10)
            {
                Console.WriteLine($"{sumHours}:0{newAfterMinutes}"); 
            }
            else
            {
                Console.WriteLine($"{sumHours}:{newAfterMinutes}");
            }
        }
    }
}
