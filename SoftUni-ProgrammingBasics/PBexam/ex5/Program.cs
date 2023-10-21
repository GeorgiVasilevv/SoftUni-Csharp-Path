using System;

namespace ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            int sea = int.Parse(Console.ReadLine());
            int mountain = int.Parse(Console.ReadLine());
            string typeOfVacation = Console.ReadLine();
            int sum = 0;
            while (typeOfVacation != "Stop")
            {
                if (typeOfVacation == "sea")
                {
                    if (sea > 0)
                    {
                        sum += 680;
                        sea--;
                    }

                }
                else if (typeOfVacation == "mountain")
                {
                    if (mountain > 0)
                    {
                        sum += 499;
                        mountain--;
                    }

                }
                if (sea + mountain == 0)
                {
                    Console.WriteLine($"Good job! Everything is sold.");
                    break;
                }
                typeOfVacation = Console.ReadLine();
            }
            
            Console.WriteLine($"Profit: {sum} leva.");
        }
    }
}
