using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _01_DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];

            for (int i = 0; i < size; i++)
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
            int primaryDiagonalSum = 0;
            int secondaryDiagonalSum = 0;

            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                primaryDiagonalSum += matrix[i, i];
            }
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                secondaryDiagonalSum += matrix[i, (matrix.GetLength(1) -1) - i];
            }
            int difference = Math.Abs(primaryDiagonalSum - secondaryDiagonalSum);
            Console.WriteLine(difference);
        }
    }
}
