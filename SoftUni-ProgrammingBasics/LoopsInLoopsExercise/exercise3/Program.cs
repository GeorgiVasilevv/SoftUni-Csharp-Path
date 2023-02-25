using System;

namespace exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            int sumPrime = 0;
            int sumNonPrime = 0;
            while (num != "stop")
            {

                if (int.Parse(num) < 0)
                {
                    Console.WriteLine("Number is negative.");
                    
                }
                else
                {
                int i;
                    for (i = 2; i <= int.Parse(num) - 1; i++)
                    {
                        if (int.Parse(num) % i == 0)
                        {
                            sumNonPrime += int.Parse(num);
                            break;
                        }
                    }
                    if (i == int.Parse(num))
                    {
                        sumPrime += int.Parse(num);
                    }
                }


                num = Console.ReadLine();
            }
            Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumNonPrime}");
        }
    }
}
