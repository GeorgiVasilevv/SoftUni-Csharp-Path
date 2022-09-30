using System;

namespace zad8
{
    class Program
    {
        static void Main(string[] args)
        {
            int godtaksa  = int.Parse(Console.ReadLine());
            double kecove = godtaksa - 0.40 * godtaksa;
            double ekip = kecove - 0.20 * kecove;
            double topka = 0.25 * ekip;
            double aksesoari = 0.2 * topka;
            double all = godtaksa + kecove + ekip + topka + aksesoari;
            Console.WriteLine(all);
        }
    }
}
