using System;
using System.Collections.Generic;
using System.Linq;

namespace _06replaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<char> uniqueCharacters = new List<char>();

            for (int i = 0; i < input.Length; i++)
            {
                if (uniqueCharacters.Count == 0 
                    || uniqueCharacters.Last() != input[i])
                {
                    uniqueCharacters.Add(input[i]);
                }
            }

            foreach (var c in uniqueCharacters)
            {
                Console.Write(c);
            }
            Console.WriteLine();
        }
    }
}
