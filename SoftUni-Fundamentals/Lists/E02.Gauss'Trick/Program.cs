using System;
using System.Collections.Generic;
using System.Linq;

namespace E02.Gauss_Trick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> organisedListOfNumbers = new List<int>();

            for (int i = 0; i < listOfNumbers.Count/2; i++)
            {
                if (listOfNumbers.Count%2==0)
                {
                    organisedListOfNumbers.Add(listOfNumbers[i] + listOfNumbers[listOfNumbers.Count-i - 1]);
                    
                }
                if (listOfNumbers.Count % 2 != 0)
                {
                    organisedListOfNumbers.Add(listOfNumbers[i] + listOfNumbers[listOfNumbers.Count - i - 1]);
                }
            }
            if (listOfNumbers.Count % 2 != 0)
            {
                organisedListOfNumbers.Add(listOfNumbers.Count / 2 + 1);
            }
            Console.WriteLine(String.Join(" ",organisedListOfNumbers));

        }
    }
}
