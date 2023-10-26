using System;
using System.Linq;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Array.Reverse(numbers);
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
