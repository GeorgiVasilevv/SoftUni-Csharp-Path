using System;

namespace ForCycles
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int sum = 0;
            int sum1 = 0;
            for (int i = 1; i <= input; i++)
            {
                int n = int.Parse(Console.ReadLine());
                if (i % 2 == 1)
                {
                    sum += n;
                }
                else if (i % 2 == 0)
                {
                    sum1 += n;
                }
            }

            if (sum == sum1)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + sum );
            }
            else if (sum != sum1)
            {
                int diff = Math.Abs(sum - sum1);
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + diff );
            }
        }
    }
}
