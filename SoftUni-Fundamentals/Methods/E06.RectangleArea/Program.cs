using System;

namespace E06.RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine(getArea(width,height));
        }
        public static double getArea(double width, double height)
        {
            return width * height;
        }
    }
}
