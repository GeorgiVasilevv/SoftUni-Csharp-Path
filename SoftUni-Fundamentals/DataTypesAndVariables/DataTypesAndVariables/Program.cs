
using System;
using System.Numerics;

namespace DataTypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());

            BigInteger sum = num1 + num2;
            sum /= num3;
            Console.WriteLine(sum *= num4); 
        }

    }
}
