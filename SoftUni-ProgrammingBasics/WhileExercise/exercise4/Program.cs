using System;

namespace exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            int stepsWalked = 0;
            string input = Console.ReadLine();
            while (stepsWalked < 10000)
            {
                if (input == "Going home")
                {
                    stepsWalked += int.Parse(Console.ReadLine());
                    break;
                }
                else if (input != "Going home")
                {
                    stepsWalked += int.Parse(input);
                }

                input = Console.ReadLine();

            }
            if (stepsWalked >= 10000)
            {
                stepsWalked -= 10000;
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{stepsWalked} steps over the goal!");
            }
            else
            {
                Console.WriteLine($"{Math.Abs(stepsWalked - 10000)} more steps to reach goal.");
            }
        }
    }
}
