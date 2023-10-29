using System;
using System.Collections.Generic;
using System.Linq;

namespace E02.OddOcurrances
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ');

            Dictionary<string ,int > wordOccurrances = new Dictionary<string ,int>();

            foreach (string word in words)
            {
                string lowerWord= word.ToLower();
                if (wordOccurrances.ContainsKey(lowerWord))
                {
                    wordOccurrances[lowerWord]++;
                }
                else
                {
                    wordOccurrances.Add(lowerWord, 1);
                }
            }
            //foreach (var item in wordOccurrances)
            //{
            //    if (item.Value %2 !=0)
            //    {
            //        Console.Write(item.Key + " ");
            //    }
            //}

            string[] wordFiltered = wordOccurrances.Where(word => word.Value % 2 != 0).Select(word => word.Key).ToArray();
            Console.WriteLine(string.Join(" ",wordFiltered));
        }
    }
}
