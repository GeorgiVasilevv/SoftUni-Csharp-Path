﻿using System;

namespace exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            double change = double.Parse(Console.ReadLine()) * 100;
            int counterChange = 0;
            while (change>0)
            {
                if (change>=200)
                {
                    change -= 200;
                }
                else if (change>=100)
                {
                    change -= 100;
                }
                else if (change >=50)
                {
                    change -= 50;
                }
                else if (change >=20)
                {
                    change -= 20;
                }
                else if (change >=10)
                {
                    change -= 10;
                }
                else if (change >=5)
                {
                    change -= 5;
                }
                else if (change >=2)
                {
                    change -= 2;
                }
                else if (change >=1)
                {
                    change -= 1;
                }
                else
                {
                    break;
                }
                counterChange++;
            }
            Console.WriteLine(counterChange);
        }
    }
}
