using System;
using System.Linq;

namespace exEx4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string[] arr2 = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            foreach (var word in arr2)
            {
                if (arr.Contains(word))
                {
                    Console.Write(word + " ");
                }
            }
        }
    }
}
