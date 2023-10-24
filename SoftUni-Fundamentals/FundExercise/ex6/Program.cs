using System;

namespace ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            long Sum = 0;
            for (int i = 0; i <= number.Length-1; i++)
            {
                char currChar = number[i];
                int currDigit = (int)currChar - 48;

                long currDigFact = 1;
                for (int z = currDigit; z >1; z--)
                {
                    currDigFact *= z;
                }
                Sum += currDigFact;
            }
            if (Sum==int.Parse(number))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }

        }
    }
}
