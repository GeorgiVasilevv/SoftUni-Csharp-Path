using System;
using System.Collections.Generic;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>() 
            {
                {"key1", "value1" }
            };

            Console.WriteLine(dict["key1"]);

        }
    }
}
