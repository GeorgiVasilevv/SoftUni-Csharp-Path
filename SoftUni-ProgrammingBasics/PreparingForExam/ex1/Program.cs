using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int rent = int.Parse(Console.ReadLine());
            double manequens = rent - (rent * 0.30);
            double kettering = manequens - (manequens * 0.15);
            double audio = kettering / 2;
            Console.WriteLine($"{rent + manequens+kettering+audio:f2}");

        }
    }
}
