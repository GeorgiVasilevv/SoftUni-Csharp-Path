using System;

namespace MoreExercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                int[] array = new int[n];
                for (int j = 0; j <= i; j++)
                {
                    int[] array2 = new int[j+1];
                    array[j] = 1;
                    array2[j] = array[j] + array[j+1];
                    Console.Write(array2[j]);
                }
                Console.WriteLine();
            }
        }
    }
}
