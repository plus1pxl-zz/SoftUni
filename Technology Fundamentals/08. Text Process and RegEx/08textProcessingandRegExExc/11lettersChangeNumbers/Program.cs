using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _11lettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine()
                .Split(" ")
                .Where(x => !string.IsNullOrWhiteSpace(x))
                .ToArray();
            string pattern = @"(?<letter1>[A-Za-z])(?<number>\d+)(?<letter2>[A-Za-z])";
            double sum = 0;

            foreach (var token in tokens)
            {
                Regex match = new Regex(pattern);

                char c1 = match.Match(token).Groups["letter1"].Value[0];
                char c2 = match.Match(token).Groups["letter2"].Value[0];
                int number = int.Parse(match.Match(token).Groups["number"].Value);
                double char1Index = char.ToUpper(c1) - 64;
                double char2Index = char.ToUpper(c2) - 64;

                double operation1 = 0;
                double operation2 = 0;

                if (c1 >= 65 && c1 <= 90)
                {
                    operation1 = number / char1Index;
                    operation2 = ProcessOperation2(c2, operation1, char2Index);
                }
                else if (c1 >= 97 && c1 <= 122)
                {
                    operation1 = number * char1Index;
                    operation2 = ProcessOperation2(c2, operation1, char2Index);
                }
                sum += operation2;
            }
            Console.WriteLine($"{sum:f2}");
        }

        private static double ProcessOperation2(char c2, double operation1, double char2Index)
        {
            double operation2 = 0;
            if (c2 >= 65 && c2 <= 90)
            {
                operation2 = operation1 - char2Index;
            }
            else if (c2 >= 97 && c2 <= 122)
            {
                operation2 = operation1 + char2Index;
            }
            return operation2;
        }
    }
}

