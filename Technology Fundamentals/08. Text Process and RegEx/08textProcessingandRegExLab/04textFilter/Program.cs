using System;

namespace _04textFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string wordsAsString = Console.ReadLine();
            var wordsToRemove = wordsAsString.Split(", ");
            string text = Console.ReadLine();

            foreach (var wordToRemove in wordsToRemove)
            {
                string newString = "";
                for (int i = 0; i < wordToRemove.Length; i++)
                {
                    newString += '*';
                }
                text = text.Replace(wordToRemove, newString);
            }
            Console.WriteLine(text);
        }
    }
}
