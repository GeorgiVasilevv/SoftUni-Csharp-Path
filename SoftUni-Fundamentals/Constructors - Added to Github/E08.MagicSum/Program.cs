using System;
using System.Linq;

namespace E08.MagicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < array.Length; i++)
            {
                int firstNum = array[i];
                for (int j = i+1; j < array.Length; j++)
                {
                    if (firstNum +array[j]==n)
                    {
                        Console.WriteLine($"{firstNum} {array[j]}");
                    }

                }
            }
        }
    }
}
