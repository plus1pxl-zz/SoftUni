using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _02_2x2_SqaresInMatrix
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            char[,] matrix = new char[size[0], size[1]];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                char[] tokens = Console.ReadLine().Replace(" ", "").ToCharArray();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = tokens[j];
                }
            }

            int foundMatrixes = 0;
            char currentCharacter = (char)0;
            int selectedRow = -1;
            int selectedCol = -1;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {

                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    currentCharacter = matrix[row, col];
                    char colNext = matrix[row, col + 1];
                    char rowNext = matrix[row + 1, col];
                    char colNextrowNext = matrix[row + 1, col + 1];
                    if (matrix[row, col + 1] == currentCharacter 
                        && matrix[row + 1, col] == currentCharacter 
                        && matrix[row + 1, col + 1] == currentCharacter)
                    {
                        selectedCol = col;
                        selectedRow = row;
                        foundMatrixes++;
                    }
                }
            }

            Console.WriteLine(foundMatrixes);
        }
    }
}
