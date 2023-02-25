using System;

namespace exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int first = 1; first <= 10; first++)
            {
                for (int secound = 1; secound <= 10; secound++)
                {
                    Console.WriteLine($"{first} * {secound} = {first*secound}" );
                }
            }
        }
    }
}
