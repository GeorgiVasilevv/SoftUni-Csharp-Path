using System;
using System.Linq;

namespace E04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words= Console.ReadLine().Split().Where(word => word.Length % 2 == 0).ToArray();
            Console.WriteLine(string.Join("\n" , words));
        }
    }
}
