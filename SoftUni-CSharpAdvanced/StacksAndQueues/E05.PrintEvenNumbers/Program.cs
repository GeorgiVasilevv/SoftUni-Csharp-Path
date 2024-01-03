using System;
using System.Collections.Generic;
using System.Linq;

namespace E05.PrintEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();
            Queue<int> indexes = new Queue<int>();

            foreach (var number in input)
            {
                if (number %2 ==0 )
                {
                    indexes.Enqueue(number);
                }
            }
            
            Console.Write(String.Join(", ",indexes));
            
        }
    }
}
