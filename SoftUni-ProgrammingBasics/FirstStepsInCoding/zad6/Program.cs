using System;

namespace zad6
{
    class Program
    {
        static void Main(string[] args)
        {
            int nailon = int.Parse(Console.ReadLine());
            int boq = int.Parse(Console.ReadLine());
            int razreditel = int.Parse(Console.ReadLine());
            int chasove = int.Parse(Console.ReadLine());


            double nailonSum = (nailon + 2 ) * 1.50;
            double procenti = 1.1;
            double boqSum = (boq + procenti) * 14.5;
            double razreditelSum = razreditel * 5.00;
            double torbichki = 0.40;
            double obshtaSuma = nailonSum + boqSum + razreditelSum + torbichki;
            double maistoriProcent = 0.30;
            double maistoriSum = (obshtaSuma * maistoriProcent) * chasove;
            double maistoriobsht = obshtaSuma + maistoriSum;



            Console.WriteLine(maistoriobsht);

        }
    }
}

  