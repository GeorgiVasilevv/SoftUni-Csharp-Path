using System;

namespace exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededMoney = double.Parse(Console.ReadLine());
            double MoneyHave = double.Parse(Console.ReadLine());
            int daysCounter = 0;
            int spendingCounter = 0;
            while (MoneyHave < neededMoney && spendingCounter < 5)
            {
                string SpendOrSave = Console.ReadLine();
                double moneySpentOrSaved = double.Parse(Console.ReadLine());
                daysCounter++;
                if (SpendOrSave == "spend")
                {
                    if (MoneyHave - moneySpentOrSaved < 0)
                    {
                        MoneyHave = 0;
                    }
                    else
                    {
                        MoneyHave -= moneySpentOrSaved;
                    }

                    spendingCounter++;
                }
                else if (SpendOrSave == "save")
                {
                    MoneyHave += moneySpentOrSaved;
                    spendingCounter = 0;
                }
            }
            if (MoneyHave >= neededMoney)
            {
                Console.WriteLine($"You saved the money for {daysCounter} days.");
            }
            if (spendingCounter==5)
            {
                Console.WriteLine($"You can't save the money.");
                Console.WriteLine($"{daysCounter}");
            }
        }
    }
}
