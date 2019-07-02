using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _05_SnakeMoves
{
    public class tartUp
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            char[,] matrix = new char[size[0], size[1]];

            char[] tokens = Console.ReadLine().Replace(" ", "").ToCharArray();
            int counter = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (counter == tokens.Length - 1)
                    {
                        matrix[i, j] = tokens[counter];
                        counter = 0;

                    }
                    else
                    {
                        matrix[i, j] = tokens[counter];
                        counter++;
                    }

                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]}");
                }
                Console.WriteLine();
            }
        }
    }
}
