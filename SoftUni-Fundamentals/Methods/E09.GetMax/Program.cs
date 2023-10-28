using System;

namespace E09.GetMax
{
    class Program
    {
        static void Main(string[] args)
        {
            string valueType = Console.ReadLine();
            if (valueType == "int")
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(a,b));
            }
            if (valueType == "char")
            {
                char a =char.Parse( Console.ReadLine());
                char b = char.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(a, b));
            }

            if (valueType=="string")
            {
                string a = Console.ReadLine();
                string b = Console.ReadLine();
                Console.WriteLine(GetMax(a,b));
            }
            

        }
        public static int GetMax(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        public static double GetMax(double a, double b)
        {
            if (a>b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        public static char GetMax(char a, char b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        public  static string GetMax(string a, string b)
        {
            if (a.CompareTo(b)>0)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
    }
}
