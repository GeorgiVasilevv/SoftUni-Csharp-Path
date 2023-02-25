using System;

namespace exx3
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int num;
            int sumPrime = 0;
            int sumNonPrime = 0;

            bool isPrime;
            while (input != "stop")
            {
                num = int.Parse(input);
                isPrime = true;

                if (num < 0)
                {
                    Console.WriteLine("Number is negative.");
                    
                }
                else
                {
                    for (int i = 2; i < num; i++)
                    {
                        if (num % i == 0)
                        {
                            isPrime = false;
                            sumNonPrime += num;
                            break;
                        }
                        
                    }
                    if (isPrime)
                    {
                        sumPrime += num;
                    }
                }
                

                input= Console.ReadLine();
            }
            Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumNonPrime}");
        }
    }
}
