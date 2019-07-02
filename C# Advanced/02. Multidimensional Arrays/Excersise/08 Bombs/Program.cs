using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _08_Bombs
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] members = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = members[j];
                }
            }

            string[] coordinatesInput = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            for (int i = 0; i < coordinatesInput.Length; i++)
            {
                int[] currentCoordinates = coordinatesInput[i]
                    .Split(",", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                int currentRow = currentCoordinates[0];
                int currentCol = currentCoordinates[1];
                int currentBombPower = matrix[currentRow, currentCol];
                if (currentBombPower > 0)
                {
                    matrix[currentRow, currentCol] = 0;

                    if (IsInside(matrix, currentRow - 1, currentCol) && matrix[currentRow - 1, currentCol] > 0)
                    {
                        matrix[currentRow - 1, currentCol] = matrix[currentRow - 1, currentCol] - currentBombPower;
                    }
                    if (IsInside(matrix, currentRow + 1, currentCol) && matrix[currentRow + 1, currentCol] > 0)
                    {
                        matrix[currentRow + 1, currentCol] = matrix[currentRow + 1, currentCol] - currentBombPower;
                    }
                    if (IsInside(matrix, currentRow, currentCol - 1) && matrix[currentRow, currentCol - 1] > 0)
                    {
                        matrix[currentRow, currentCol - 1] = matrix[currentRow, currentCol - 1] - currentBombPower;
                    }
                    if (IsInside(matrix, currentRow, currentCol + 1) && matrix[currentRow, currentCol + 1] > 0)
                    {
                        matrix[currentRow, currentCol + 1] = matrix[currentRow, currentCol + 1] - currentBombPower;
                    }
                    if (IsInside(matrix, currentRow - 1, currentCol - 1) && matrix[currentRow - 1, currentCol - 1] > 0)
                    {
                        matrix[currentRow - 1, currentCol - 1] = matrix[currentRow - 1, currentCol - 1] - currentBombPower;
                    }
                    if (IsInside(matrix, currentRow - 1, currentCol + 1) && matrix[currentRow - 1, currentCol + 1] > 0)
                    {
                        matrix[currentRow - 1, currentCol + 1] = matrix[currentRow - 1, currentCol + 1] - currentBombPower;
                    }
                    if (IsInside(matrix, currentRow + 1, currentCol - 1) && matrix[currentRow + 1, currentCol - 1] > 0)
                    {
                        matrix[currentRow + 1, currentCol - 1] = matrix[currentRow + 1, currentCol - 1] - currentBombPower;
                    }
                    if (IsInside(matrix, currentRow + 1, currentCol + 1) && matrix[currentRow + 1, currentCol + 1] > 0)
                    {
                        matrix[currentRow + 1, currentCol + 1] = matrix[currentRow + 1, currentCol + 1] - currentBombPower;
                    }
                }

            }
            int aliveCells = 0;
            int aliveCellsSum = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] > 0)
                    {
                        aliveCells++;
                        aliveCellsSum += matrix[row, col];
                    }
                }
            }
            Console.WriteLine($"Alive cells: {aliveCells}");
            Console.WriteLine($"Sum: {aliveCellsSum}");
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }
                Console.WriteLine();
            }
        }

        private static bool IsInside(int[,] matrix, int desiredRow, int desiredCol)
        {
            return desiredRow < matrix.GetLength(0) 
                && desiredRow >= 0
                && desiredCol < matrix.GetLength(1)
                && desiredCol >= 0;
        }
    }
}
