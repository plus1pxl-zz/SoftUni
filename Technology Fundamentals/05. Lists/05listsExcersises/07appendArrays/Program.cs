using System;
using System.Collections.Generic;
using System.Linq;

namespace _07appendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split('|')
                .ToList();
            List<int> output = new List<int>();
            for (int i = input.Count - 1; i >= 0; i--)
            {
                List<int> temp = input[i]
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();
                for (int j = 0; j < temp.Count; j++)
                {
                    output.Add(temp[j]);
                }
            }
            Console.WriteLine(string.Join(' ', output));
        }
    }
}
