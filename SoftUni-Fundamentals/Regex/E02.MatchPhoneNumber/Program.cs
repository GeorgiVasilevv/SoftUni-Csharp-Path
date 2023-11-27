using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace E02.MatchPhoneNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\+359([\s|\-])2\1(\d{3})\1(\d{4})\b";
            string text = Console.ReadLine();
            MatchCollection matches  = Regex.Matches(text, pattern);
            List<string> matchess = new List<string>();
            foreach (Match match in matches)
            {
                matchess.Add(match.Value);
            }
            Console.WriteLine(string.Join(", ",matchess));
        }
    }
}
