using System;
using System.Linq;

namespace ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).
                ToArray();
            int Odd = 0;
            int Even = 0;
            foreach (var item in nums)
            {
                if (item%2==0)
                {
                    Even += item;
                }
                else
                {
                    Odd += item;
                }
            }
            int sum = Even-Odd;
            Console.WriteLine(sum);
        }
    }
}
