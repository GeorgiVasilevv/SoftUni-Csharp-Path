using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorials
{
    class Car
    {
        public string model;
        public string color;
        public int year;
        public static string fullThrottle(string a, string b)
        {
            string c = a + " " + b;
            Console.WriteLine("The car is going as fast as it can!");
            return c; 
        }
    }
    }
