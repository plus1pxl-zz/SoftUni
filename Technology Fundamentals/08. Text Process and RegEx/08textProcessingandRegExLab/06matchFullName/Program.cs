using System;
using System.Text.RegularExpressions;

namespace _06matchFullName
{
    class Program
    {
        private static object regex;

        static void Main(string[] args)
        {
            string regex = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            string line = Console.ReadLine();

            MatchCollection matched = Regex.Matches(line, regex);

            foreach (var name in matched)
            {
                Console.Write(name + " ");
            }
        }
    }
}
