using System;

namespace exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            int food = int.Parse(Console.ReadLine());
            food *= 1000;
            string gramsEaten = Console.ReadLine();
            while (gramsEaten!="Adopted" )
            {
                food -= int.Parse(gramsEaten);
                gramsEaten = Console.ReadLine();
            }
            if (food<0)
            {
                Console.WriteLine($"Food is not enough. You need {Math.Abs(food)} grams more.");
            }
            else if (food>=0)
            {
                Console.WriteLine($"Food is enough! Leftovers: {food} grams.");
            }
        }
    }
}
