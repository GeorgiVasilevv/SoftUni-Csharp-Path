using System;

namespace LoopsInLoopsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int current = 1;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <=i; j++)
                {
                    if (current>n)
                    {
                        return;
                    }
                    Console.Write(current + " ");
                    current++;
                }
                Console.WriteLine();
            }
        }
    }
}
