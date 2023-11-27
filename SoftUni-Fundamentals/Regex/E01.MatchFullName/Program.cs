using System;
using System.Text.RegularExpressions;

namespace E01.MatchFullName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b(?<first>[A-Z][a-z]{1,}) (?<last>[A-Z][a-z]{1,})\b";
            string names = Console.ReadLine();
            MatchCollection validNames = Regex.Matches(names, pattern);

            foreach (Match match in validNames)
            {
                Console.Write(match.Value + " ");
            }
        }
    }
}
