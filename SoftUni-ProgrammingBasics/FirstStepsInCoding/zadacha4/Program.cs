using System;

namespace zadacha4
{
    class Program
    {
        static void Main(string[] args)
        {
            int himikali = int.Parse(Console.ReadLine());
            int markeri = int.Parse(Console.ReadLine());
            int preparat = int.Parse(Console.ReadLine());
            double procent = int.Parse(Console.ReadLine());

            double paketih = himikali * 5.80;
            double paketim = markeri * 7.20;
            double preparatcena = preparat * 1.20;
            double vsichkimat =  paketih + paketim + preparatcena;
            double procentii = procent / 100;
            double namalenie = vsichkimat - (vsichkimat * procentii);
            Console.WriteLine(namalenie);
        }
    }
}
