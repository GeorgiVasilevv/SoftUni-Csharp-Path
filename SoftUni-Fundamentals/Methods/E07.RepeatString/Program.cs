using System;
using System.Text;

namespace E07.RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string @string = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(RepeatString(@string,n));
        }
        static string RepeatString(string repeatedString, int n)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                stringBuilder.Append(repeatedString);
            }
            return stringBuilder.ToString();
        }
    }
}
