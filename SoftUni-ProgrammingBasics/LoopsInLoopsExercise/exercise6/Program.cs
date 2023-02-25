using System;

namespace exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            string projection = Console.ReadLine();
            double counterAll = 0;
            int counterStudent = 0;
            int counterStandart = 0;
            int counterKid = 0;
            while (projection != "Finish")
            {
                double seats = double.Parse(Console.ReadLine());
                string typeOfProjection = Console.ReadLine();
                int counter = 0;
                bool flag = true;
                while (typeOfProjection != "End" || counter == seats)
                {
                    if (typeOfProjection == "Finish")
                    {
                        flag = false;
                        break;
                    }
                    if (typeOfProjection == "student")
                    {
                        counter++;
                        counterAll++;
                        counterStudent++;
                    }
                    else if (typeOfProjection == "standard")
                    {
                        counter++;
                        counterAll++;
                        counterStandart++;
                    }
                    else if (typeOfProjection == "kid")
                    {
                        counter++;
                        counterAll++;
                        counterKid++;
                    }
                    typeOfProjection = Console.ReadLine();
                }
                Console.WriteLine($"{projection} - {((counter / (double)seats) * 100):f2}% full.");
                if (flag == false)
                {
                    break;
                }
                projection = Console.ReadLine();
            }
            Console.WriteLine($"Total tickets: {counterAll}");
            Console.WriteLine($"{((counterStudent/ (double)counterAll)* 100):f2}% student tickets.");
            Console.WriteLine($"{((counterStandart/ (double)counterAll)* 100):f2}% standard tickets.");
            Console.WriteLine($"{((counterKid / (double)counterAll) * 100):f2}% kids tickets.");
        }
    }
}
