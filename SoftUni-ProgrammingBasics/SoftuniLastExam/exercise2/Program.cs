using System;

namespace exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            double heigth = double.Parse(Console.ReadLine());
            double heigthAustronaut = double.Parse(Console.ReadLine());

            double rocketSpace = width * length * heigth;
            double roomSpace = (heigthAustronaut + 0.40) * 2 * 2;
            double spaceForPeople =Math.Floor( rocketSpace / roomSpace);

            if (spaceForPeople>=3 && spaceForPeople<=10)
            {
                Console.WriteLine($"The spacecraft holds {spaceForPeople} astronauts.");
            }
            else if (spaceForPeople <3)
            {
                Console.WriteLine($"The spacecraft is too small.");
            }
            else if (spaceForPeople > 10)
            {
                Console.WriteLine("The spacecraft is too big.");
            }

        }
    }
}
