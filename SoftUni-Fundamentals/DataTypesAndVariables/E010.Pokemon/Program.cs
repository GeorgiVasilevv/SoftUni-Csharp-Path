using System;

namespace E010.Pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int pokesCounter = 0;
            int nAtStart = n;
            while (m<=n)
            {
                if (nAtStart ==n * 2)
                {
                    if (y>0)
                    {
                    n /= y;
                        
                    }
                    if (n < m)
                    {
                        continue;
                    }
                }
                n -= m;
                pokesCounter++;
            }
            Console.WriteLine(n);
            Console.WriteLine(pokesCounter);

        }
    }
}
