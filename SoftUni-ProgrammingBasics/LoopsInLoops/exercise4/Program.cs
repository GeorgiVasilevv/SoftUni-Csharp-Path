using System;

namespace exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = start; i <= end; i++)
            {
                for (int j= start; j <= end; j++)
                {
                    
                    int sum = i + j;
                    counter++;
                    if (sum==magicNum)
                    {
                        Console.WriteLine($"Combination N:{counter} ({i} + {j} = {magicNum})");
                        return;
                    }

                }
            }
            Console.WriteLine($"{counter} combinations - neither equals {magicNum}");
        }
    }
}
