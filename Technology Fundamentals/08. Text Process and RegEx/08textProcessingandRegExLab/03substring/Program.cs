using System;

namespace _03substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string line = Console.ReadLine();
            while (line.Contains(word))
            {
                line = line.Replace(word, string.Empty);
            }

            Console.WriteLine(line);
        }
    }
}
