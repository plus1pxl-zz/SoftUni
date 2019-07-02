using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _03_MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int squareSize = 3;
            int[] size = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[,] matrix = new int[size[0], size[1]];

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

            int maxSum = Int32.MinValue;
            int selectedRow = -1;
            int selectedCol = -1;

            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    int sum = 0;
                    for (int i = 0; i < squareSize; i++)
                    {
                        for (int j = 0; j < squareSize; j++)
                        {
                            sum += matrix[row + i, col + j];
                        }
                    }
                    if (maxSum < sum)
                    {
                        maxSum = sum;
                        selectedCol = col;
                        selectedRow = row;
                    }
                }
            }
            Console.WriteLine($"Sum = {maxSum}");
            for (int i = 0; i < squareSize; i++)
            {
                for (int j = 0; j < squareSize; j++)
                {
                    Console.Write($"{matrix[(selectedRow + i),(selectedCol + j)]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
