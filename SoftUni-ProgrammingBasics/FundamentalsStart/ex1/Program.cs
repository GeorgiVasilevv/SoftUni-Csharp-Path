using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            double avarageGrade = double.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}, Age: { age}, Grade: {avarageGrade:f2}");
        }
    }
}
