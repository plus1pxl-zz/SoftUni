using System;
using System.Linq;

namespace _08magicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < input.Length - 1; i++)
            {
                for (int j = i + 1; j <= input.Length - 1; j++)
                {
                    if (input[i] + input[j] == n)
                    {
                        Console.WriteLine($"{input[i]} {input[j]}");
                    }
                }
            }
        }

    }
}
