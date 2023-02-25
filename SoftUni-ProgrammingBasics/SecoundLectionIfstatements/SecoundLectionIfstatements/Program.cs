using System;

namespace SecoundLectionIfstatements
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            double area = 0;
            if (type == "square")
            {
                double a = double.Parse(Console.ReadLine());
                area = a * a;
            }
            if (type == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                area = a * b;
            }
            if (type == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                area = (r * r * Math.PI);
            }
            if (type == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double ha = double.Parse(Console.ReadLine());
                area = a * ha / 2;
            }
            Console.WriteLine($"{area:F3}");
        }
    }
    }

