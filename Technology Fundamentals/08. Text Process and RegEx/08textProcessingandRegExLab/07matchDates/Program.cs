using System;
using System.Text.RegularExpressions;

namespace _07matchDates
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"\b(?<day>\d{2})([-.\/])(?<month>[A-Z][a-z]{2})\2(?<year>\d{4})\b";
            string line = Console.ReadLine();

            MatchCollection matched = Regex.Matches(line, regex);

            foreach (Match date in matched)
            {
                string day = date.Groups["day"].Value;
                string month = date.Groups["month"].Value;
                string year = date.Groups["month"].Value;
                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
