using System;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                int litresPoured = int.Parse(Console.ReadLine());
                
                if (sum+litresPoured>255)
                {
                    Console.WriteLine("Insufficient capacity!");
                    continue;
                }
                sum += litresPoured;
            }
            Console.WriteLine(sum);

        }
    }

}

