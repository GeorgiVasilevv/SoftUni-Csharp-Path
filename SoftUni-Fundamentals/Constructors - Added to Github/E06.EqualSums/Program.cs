using System;
using System.Linq;

namespace E06.EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();


            for (int i = 0; i < array.Length; i++)
            {
                int sumToTheLeft = 0;
                int sumToTheRight = 0;

                for (int j = i + 1; j < array.Length; j++)
                {
                    sumToTheRight += array[j];
                    
                }
                for (int k  = i-1; k  >=0 ; k --)
                {
                    sumToTheLeft += array[k];
                }
                if (sumToTheLeft==sumToTheRight)
                {
                    Console.WriteLine(i);
                    return;
                }
                
            }
            Console.WriteLine("no");
        }
    }
}
