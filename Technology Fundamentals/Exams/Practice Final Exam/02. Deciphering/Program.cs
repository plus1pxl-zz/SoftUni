using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02deciphering
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] cypher = Console.ReadLine().Split().ToArray();
            string pattern = @"[d-z{}|#]*";

            // check for matches
            Match match = Regex.Match(input, pattern);
            if (match.Length != input.Length)
            {
                Console.WriteLine("This is not the book you are looking for.");
            }
            else
            {
                char[] inputAsChars = input.ToCharArray();
                for (int i = 0; i < inputAsChars.Length; i++)
                {
                    inputAsChars[i] = (char)((int)inputAsChars[i] - 3);
                }
                string processed = new string(inputAsChars);
                Console.WriteLine(processed.Replace(cypher[0], cypher[1]));

            }
        }
    }
}
