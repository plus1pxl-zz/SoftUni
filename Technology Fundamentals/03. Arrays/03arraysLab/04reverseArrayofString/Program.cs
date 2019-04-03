using System;

namespace _04reverseArrayofString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] tokens = input.Split(' ');
            Array.Reverse(tokens);
            foreach (var item in tokens)
            {
                Console.Write($"{item} ");
            }

        }
    }
}
