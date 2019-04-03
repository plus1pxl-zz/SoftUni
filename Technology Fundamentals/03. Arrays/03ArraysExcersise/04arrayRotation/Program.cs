using System;
using System.Linq;

namespace _04arrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int firstElement = input[0];
                for (int j = 0; j < input.Length - 1; j++)
                {
                    input[j] = input[j + 1];
                }
                input[input.Length - 1] = firstElement;
            }
            string output = string.Join(" ", input);

            Console.WriteLine(output);
        }
    }
}
