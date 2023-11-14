using System;
using System.Numerics;

namespace E02_BigFactorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BigInteger bigInt = 1;
            
            int n = int.Parse(Console.ReadLine());

            for (int i = 2; i <= n; i++)
            {
                bigInt *= i;
            }
            Console.WriteLine(bigInt);
        }
    }
}
