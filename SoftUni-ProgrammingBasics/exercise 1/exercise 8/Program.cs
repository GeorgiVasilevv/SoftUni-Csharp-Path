using System;

namespace exercise_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHours = int.Parse(Console.ReadLine());
            int examMin = int.Parse(Console.ReadLine());
            int arrivalHours = int.Parse(Console.ReadLine());
            int arrivalMin = int.Parse(Console.ReadLine());
            string time = "";

            int examStart = examHours * 60 + examMin; //total start in minutes
            int arrival = arrivalHours * 60 + arrivalMin;
            int difference = (arrival - examStart); // total difference in minutes
            int differenceHours = Math.Abs(difference / 60);
            int differenceMinutes = Math.Abs(difference) - differenceHours * 60;

            if (difference>0)
            {
                time = "Late";
                Console.WriteLine(time);
                
                if (difference < 60)
                {
                    
                    Console.WriteLine($"{differenceMinutes} minutes after the start");
                }
                else if (difference >= 60)
                {

                    Console.WriteLine($"{Math.Abs(differenceHours)}:{Math.Abs(differenceMinutes):00} hours after the start");
                }
            }


            else if (difference <= 0 && difference >= -30)
            {
                time = "On time";
                if (difference != 0)
                {
                    Console.WriteLine(time);
                    Console.WriteLine("{0} minutes before the start", Math.Abs(differenceMinutes));
                }
                else
                {
                    Console.WriteLine(time);
                }
            }
            else if (difference<-30)
            {
                time = "Early";
                Console.WriteLine(time);
                
                if (difference < -30 && difference > -60)
                {
                    Console.WriteLine("{0} minutes before the start", Math.Abs(differenceMinutes));
                }
                else
                {

                    Console.WriteLine("{0}:{1:00} hours before the start", Math.Abs(differenceHours), Math.Abs(differenceMinutes));

                }

            }
        }
    }
}
