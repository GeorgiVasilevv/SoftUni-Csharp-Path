using System;

namespace exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());


            for (int i = num1; i <= num2; i++)
            {
                int sumodd = 0;
                int sumeven = 0;
                string currentNum = i.ToString();
                for (int j = 0; j < currentNum.Length; j++)
                {
                    int currentDigit = int.Parse(currentNum[j].ToString());
                    if (j%2==0)
                    {
                        sumeven += currentDigit;
                    }
                    else
                    {
                        sumodd += currentDigit;
                    }
                }
                if (sumeven==sumodd)
                {
                    Console.Write(i+" ");
                }
            }
        }
    }
}
