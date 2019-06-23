using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _04_PrimaryDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int dim = int.Parse(Console.ReadLine());

            int[,] matrix = new int[dim, dim];


            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] tokens = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = tokens[j];
                }
            }
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sum += matrix[i, i];
            }
            Console.WriteLine(sum);
        }
    }
}
