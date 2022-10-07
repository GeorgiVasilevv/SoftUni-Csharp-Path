using System;

namespace exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int peopleSum = 0;
            double musala = 0, monblan = 0, killimandjaro = 0, k2 = 0, everest = 0;
            for (int i = 0; i < n; i++)
            {
                int people = int.Parse(Console.ReadLine());
                peopleSum = peopleSum + people;
                if (people <= 5)
                {
                    musala=musala+people;
                }
                else if (people <= 12)
                {
                    monblan = monblan + people;
                }
                else if (people <= 25)
                {
                    killimandjaro = killimandjaro + people;
                }
                else if (people <= 40)
                {
                    k2 = k2 + people;
                }
                else if (people >= 41)
                {
                    everest = everest + people;
                }
            }
            musala = musala / peopleSum * 100;
            monblan = monblan / peopleSum * 100;
            killimandjaro = killimandjaro / peopleSum * 100;
            k2 = k2 / peopleSum * 100;
            everest = everest / peopleSum * 100;
            Console.WriteLine($"{musala:f2}%");
            Console.WriteLine($"{monblan:f2}%");
            Console.WriteLine($"{killimandjaro:f2}%");
            Console.WriteLine($"{k2:f2}%");
            Console.WriteLine($"{everest:f2}%");

        }
    }
}
