using System;

namespace exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int failcounter = 0;
            int year = 1;
            double avarageGrade = 0;
            while (year <= 12)
            {
                double yearlyGrade = double.Parse(Console.ReadLine());

                if (yearlyGrade < 4.00)
                {
                    failcounter++;
                    if (failcounter >= 2)
                    {
                        break;
                    }
                    continue;
                }

                avarageGrade += yearlyGrade;
                year++;

            }
            avarageGrade = avarageGrade / 12;

            if (failcounter >= 2)
            {
                Console.WriteLine($"{name} has been excluded at {year} grade");
            }

            else
            {
                Console.WriteLine($"{name} graduated. Average grade: {avarageGrade:f2}");
            }

        }
    }
}
