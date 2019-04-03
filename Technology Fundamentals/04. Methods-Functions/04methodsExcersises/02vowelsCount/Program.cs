using System;

namespace _02vowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(FindNumberOfVowels(input.ToLower()));
        }

        static int FindNumberOfVowels(string input)
        {
            int counter = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'a'
                    || input[i] == 'e'
                    || input[i] == 'i'
                    || input[i] == 'o'
                    || input[i] == 'u')
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
