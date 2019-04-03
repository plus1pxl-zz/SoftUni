using System;
using System.Collections.Generic;

namespace _02randomizeWords
{
    class Program
    {
        static void Main()
        {
            var words = Console.ReadLine().Split(' ');
            var random = new Random();
            var shuffleWords = new List<string>();
            foreach (var word in words)
            {
                int newIndex = random.Next(0, shuffleWords.Count + 1);
                shuffleWords.Insert(newIndex, word);
            }

            foreach (var word in shuffleWords)
            {
                Console.WriteLine(word);
            }
        }
    }
}
