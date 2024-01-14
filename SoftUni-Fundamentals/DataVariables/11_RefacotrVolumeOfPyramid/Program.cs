using System;

namespace _11_RefacotrVolumeOfPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Length: ");
            double height = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            double length = double.Parse(Console.ReadLine());
            double volume = (height * width * length) / 3;
            Console.WriteLine($"Pyramid Volume: {volume:f2}");

        }
    }
}
