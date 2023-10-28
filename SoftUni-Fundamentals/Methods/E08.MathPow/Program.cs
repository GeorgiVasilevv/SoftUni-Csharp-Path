using System;

namespace E08.MathPow
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            Console.WriteLine(CalculatePow(number,power));
        }
        static double CalculatePow(double number, int power) 
        {
            return Math.Pow(number, power);
        }
    }
}
