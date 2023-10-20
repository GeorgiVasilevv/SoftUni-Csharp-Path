using System;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            int countEggs = int.Parse(Console.ReadLine());

            int countRed = 0;
            int countOrange = 0;
            int countBlue  = 0;
            int countGreen = 0;

            for (int i = 0; i < countEggs; i++)
            {
                string color = Console.ReadLine();
                if (color=="red")
                {
                    countRed++;
                }
                else if (color == "orange")
                {
                    countOrange++;
                }
                else if (color == "blue")
                {
                    countBlue++;
                }
                else if (color == "green")
                {
                    countGreen++;
                }
            }
            Console.WriteLine($"Red eggs: {countRed}");
            Console.WriteLine($"Orange eggs: {countOrange}");
            Console.WriteLine($"Blue eggs: {countBlue}");
            Console.WriteLine($"Green eggs: {countGreen}");

            if (countRed> countOrange && countRed> countBlue && countRed>countGreen)
            {
                Console.WriteLine($"Max eggs: {countRed} -> red");
            }
            else if (countOrange > countRed && countOrange > countBlue && countOrange > countGreen)
            {
                Console.WriteLine($"Max eggs: {countOrange} -> orange");
            }
            else if (countBlue > countRed && countBlue > countOrange && countBlue > countGreen)
            {
                Console.WriteLine($"Max eggs: {countBlue} -> blue");
            }
            else if (countGreen > countRed && countGreen > countOrange && countGreen > countBlue)
            {
                Console.WriteLine($"Max eggs: {countGreen} -> green");
            }
        }
    }
}
