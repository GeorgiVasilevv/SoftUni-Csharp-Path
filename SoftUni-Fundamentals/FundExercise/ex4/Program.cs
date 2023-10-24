using System;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int Sum=0;
            for (int i = number1; i <= number2; i++)
            {
                Sum += i;
                Console.Write(i + " ");
            }
            
            Console.WriteLine("\nSum: " + Sum);

        }
    }
}
