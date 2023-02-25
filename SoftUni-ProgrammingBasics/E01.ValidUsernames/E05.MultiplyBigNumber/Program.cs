using System;
using System.Collections.Generic;

namespace E05.MultiplyBigNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string num1 = Console.ReadLine();
            int num2 = int.Parse(Console.ReadLine());
            List<string> newNum = new List<string>();
            int leftover = 0;
            if (num1.StartsWith("0"))
            {
                num1 =num1.TrimStart('0');
            }
            if (num2==0)
            {
                Console.WriteLine("0");
                return;
            }
            for (int i = num1.Length-1; i >=0; i--)
            {
                int number = int.Parse(num1[i].ToString());
                leftover = number * num2 + leftover;
                newNum.Insert(0,(leftover%10).ToString());
                leftover = leftover / 10;
            }
            if (leftover>0)
            {
                Console.WriteLine($"{leftover}{string.Join("",newNum)}");
            }
            else
            {
                Console.WriteLine($"{string.Join("", newNum)}");

            }
        }
    }
}
