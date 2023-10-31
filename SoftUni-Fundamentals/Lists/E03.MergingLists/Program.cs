using System;
using System.Collections.Generic;
using System.Linq;

namespace E03.MergingLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listOne = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> listTwo = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> listResults = new List<int>();

            int longerList = Math.Max(listOne.Count, listTwo.Count);
            for (int i = 0; i < longerList; i++)
            {
                if (i<listOne.Count)
                {
                    listResults.Add(listOne[i]);
                }
                if (i < listTwo.Count)
                {
                    listResults.Add(listTwo[i]);
                }
            }
            Console.WriteLine(String.Join(" ",listResults));

        }
       

    }
}
