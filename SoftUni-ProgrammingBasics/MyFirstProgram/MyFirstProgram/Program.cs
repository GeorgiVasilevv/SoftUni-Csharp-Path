using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            double land = double.Parse(Console.ReadLine());
            double final = land * 7.61;
            double disscount = final * 0.18;
            double diss = final - disscount;
            Console.WriteLine($"The final price is: {diss} lv.");
            Console.WriteLine($"The discount is: {disscount} lv.");
        }
    }
}
