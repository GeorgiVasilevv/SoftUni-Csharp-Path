using System;
using System.Linq;

namespace Ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOne = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToArray();

            int origialLength = arrayOne.Length;
            for (int i = 0; i < origialLength-1; i++)
            {
                int[] condensed = new int[arrayOne.Length - 1] ;
                for (int j = 0; j < arrayOne.Length-1; j++)
                {
                    condensed[j] = arrayOne[j] + arrayOne[j + 1];
                }
                arrayOne = condensed;
            }
            Console.WriteLine(arrayOne[0]);
        }
    }
}
