using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _03_WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = File.ReadAllText(@"files\words.txt").Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            var dictionary = new Dictionary<string, int>();
            foreach (var word in words)
            {
                dictionary.Add(word, 0);
            }

                foreach (string line in File.ReadLines(@"files\text.txt"))
                {
                for (int i = 0; i < words.Length; i++)
                {
                    if (line.Contains(words[i]))
                    {
                        dictionary[words[i]]++;
                    }
                }
                }

            using (var writer = new StreamWriter("output.txt"))
            {
                foreach (var kvp in dictionary.OrderByDescending(x => x.Value))
                {
                    writer.WriteLine(kvp.Key + " - " + kvp.Value);
                    Console.WriteLine(kvp.Key + " - " + kvp.Value);
                }
            }
        }
    }
}
