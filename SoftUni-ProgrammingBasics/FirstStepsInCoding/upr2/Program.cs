using System;

namespace upr2
{
    class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            int srok = int.Parse(Console.ReadLine());
            double procent = double.Parse(Console.ReadLine());
            double lihva = deposit * (procent / 100);
            double lihva1mesec = lihva / 12;
            Console.WriteLine(deposit + srok * lihva1mesec);
        }
    }
}
