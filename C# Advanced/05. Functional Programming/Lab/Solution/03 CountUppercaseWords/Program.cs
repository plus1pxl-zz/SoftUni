using System;
using System.Linq;

namespace _03_CountUppercaseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Where(w => Char.IsUpper(w[0]))
            .ToList()
            .ForEach(Console.WriteLine);
        }
    }
}
