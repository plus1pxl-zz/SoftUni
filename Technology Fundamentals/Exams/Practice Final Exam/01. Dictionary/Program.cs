using System;
using System.Collections.Generic;
using System.Linq;

namespace _01dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = new Dictionary<string, List<string>>();

            string[] tokens = Console.ReadLine().Split(" | ").ToArray();

            for (int i = 0; i < tokens.Length; i++)
            {
                string[] wordDefinition = tokens[i].Split(": ").ToArray();

                string word = wordDefinition[0];
                string definition = wordDefinition[1];

                if (!words.ContainsKey(word))
                {
                    words.Add(word, new List<string>());
                    words[word].Add(definition);
                }
                else
                {
                    words[word].Add(definition);
                }
            }

            string[] wordsToShow = Console.ReadLine().Split(" | ").ToArray();

            foreach (var word in wordsToShow)
            {
                foreach (var kvp in words)
                {
                    if (kvp.Key == word)
                    {
                        Console.WriteLine($"{kvp.Key}:");
                        foreach (var w in kvp.Value.OrderByDescending(x => x.Length))
                        {
                            Console.WriteLine($" -{w}");
                        }
                    }
                }
            }

            string finalInput = Console.ReadLine();
            if (finalInput.ToLower() == "list")
            {
                var output = String.Join(" ", words.Keys.OrderBy(x => x).ToArray());
                Console.WriteLine(output);
            }
            else if (finalInput.ToLower() == "end")
            {
                Environment.Exit(0);
            }
        }
    }
}
