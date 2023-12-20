using System;
using System.Text.RegularExpressions;

namespace E03.MatchDates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b(?<day>\d{2})(\.|\-|\/)(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b";
            string dates = Console.ReadLine();
            MatchCollection matches = Regex.Matches(dates, pattern);
            foreach (Match match in matches)
            {
                int day = int.Parse(match.Groups["day"].Value);
                string month = match.Groups["month"].Value;
                int year = int.Parse(match.Groups["year"].Value);
                Console.WriteLine($"Day: {day:d2}, Month: {month}, Year: {year}");
            }
        }
    }
}
