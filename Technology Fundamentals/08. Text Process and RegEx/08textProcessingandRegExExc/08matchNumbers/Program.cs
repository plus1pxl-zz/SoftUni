using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _08matchNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";
            string input = Console.ReadLine();

            List<string> numbers = new List<string>();
            MatchCollection matched = Regex.Matches(input, regex);

            foreach (Match number  in matched)
            {
                numbers.Add(number.Value);
            }
            Console.WriteLine(string.Join(" ", numbers));
            
        }
    }
}
