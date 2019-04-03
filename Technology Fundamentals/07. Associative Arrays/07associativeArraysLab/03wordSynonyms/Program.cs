﻿using System;
using System.Collections.Generic;

namespace _03wordSynonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var dictionary = new Dictionary<string, List<string>>();
            for (int i = 1; i <= n; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (!dictionary.ContainsKey(word))
                {
                    dictionary.Add(word, new List<string>());  
                }
                dictionary[word].Add(synonym);

                foreach (var item in dictionary)
                {
                    Console.WriteLine($"{item.Key} - {string.Join(", ", item.Value)}");
                }
            }
        }
    }
}
