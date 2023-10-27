using System;
using System.Linq;

namespace E03.ZigZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arrayOdd = new int[n];
            int[] arrayEven = new int[n];

            for (int rows = 1; rows <= n; rows++)
            {
                int[] currentNumbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                int firstnumber = currentNumbers[0];
                int secoundNumber = currentNumbers[1];

                if (rows%2!=0)
                {
                    arrayOdd[rows - 1] = firstnumber;
                    arrayEven[rows - 1] = secoundNumber;
                }
                else
                {
                    arrayOdd[rows - 1] = secoundNumber;
                    arrayEven[rows - 1] = firstnumber;
                }
            }
            Console.WriteLine(string.Join(" ", arrayOdd));
            Console.WriteLine(string.Join(" ", arrayEven));

        }
    }
}
