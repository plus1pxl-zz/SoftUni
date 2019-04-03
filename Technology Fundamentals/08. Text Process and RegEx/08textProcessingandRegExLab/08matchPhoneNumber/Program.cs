using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _08matchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"(?<!\d)[+]359([ -])2\1\d{3}\1\d{4}\b";
            string line = Console.ReadLine();

            List<string> numbers = new List<string>();
            MatchCollection matched = Regex.Matches(line, regex);

            foreach (Match telephoneN in matched)
            {
                numbers.Add(telephoneN.Value);
            }
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
