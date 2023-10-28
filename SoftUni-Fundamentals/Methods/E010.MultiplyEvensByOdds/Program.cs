using System;

namespace E010.MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(GetSumOfEvenNumbers(num) * GetSumOfOddNumbers(num));

        }
        static int GetSumOfEvenNumbers(int num)
        {
            int numm = Math.Abs(num);
            int SumOfEven = 0;
            while (numm != 0)
            {
                int temp = numm % 10;
                if (temp % 2 == 0)
                {
                    SumOfEven += temp;
                }
                numm = numm / 10;
            }
            return SumOfEven;
        }

        static int GetSumOfOddNumbers(int num)
        {
            int numm = Math.Abs(num);
            int SumOfOdd = 0;
            while (numm != 0)
            {
                int temp = numm % 10;
                if (temp % 2 == 1)
                {
                    SumOfOdd += temp;
                }
                numm = numm / 10;
            }
            return SumOfOdd;
        }
    }
}
