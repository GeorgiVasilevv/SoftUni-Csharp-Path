using System;
using System.Collections.Generic;
using System.Linq;

namespace E04.EvenTimes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,int> keyValuePairs = new Dictionary<int,int>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (!keyValuePairs.ContainsKey(number))
                {
                    keyValuePairs.Add(number, 0);
                }
                keyValuePairs[number]++;

            }

            Console.WriteLine(keyValuePairs.Single(x=> x.Value%2==0).Key);
        }
    }
}
