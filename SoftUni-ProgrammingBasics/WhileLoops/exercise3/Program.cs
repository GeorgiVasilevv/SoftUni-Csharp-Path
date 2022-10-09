using System;

namespace exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;

            while (num > sum)
            {
                int currentnum = int.Parse(Console.ReadLine());
                sum += currentnum;

            }
            Console.WriteLine(sum);
        }
    }
}
