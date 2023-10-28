using System;

namespace _04.Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int end = int.Parse(Console.ReadLine());
            for (int i = 1; i < end; i++)
            {
                PrintLine(i);
            }
            for (int i = end; i > 0; i--)
            {
                PrintLine(i);
            }
        }
        static void PrintLine(int end)
        {
            for (int i = 1; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
