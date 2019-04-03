using System;
using System.Collections.Generic;

namespace _07associativeArraysExcersise
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();

            var characters = new Dictionary<char, int>();

            foreach (var character in line)
            {
                if (character != ' ')
                {
                    if (characters.ContainsKey(character))
                    {
                        characters[character] += 1;
                    }
                    else
                    {
                        characters.Add(character, 1);
                    }
                }
            }
            foreach (var character in characters)
            {
                Console.WriteLine(character.Key + " -> " + character.Value);
            }
        }
    }
}
