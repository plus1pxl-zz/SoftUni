using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _04_MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string[,] matrix = new string[size[0], size[1]];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = tokens[j];
                }
            }

            string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            while (command[0]?.ToLower() != "end")
            {

                if (command[0]?.ToLower() == "swap" && command.Length == 5)
                {
                    int row1 = int.Parse(command[1]);
                    int col1 = int.Parse(command[2]);
                    int row2 = int.Parse(command[3]);
                    int col2 = int.Parse(command[4]);

                    if (matrix.GetLength(0) >= row1 
                        && matrix.GetLength(1) >= col1
                        && matrix.GetLength(0) >= row2
                        && matrix.GetLength(1) >= col2)
                    {
                        string str1 = matrix[row1, col1];
                        string str2 = matrix[row2, col2];

                        matrix[row2, col2] = str1;
                        matrix[row1, col1] = str2;

                        for (int i = 0; i < matrix.GetLength(0); i++)
                        {
                            for (int j = 0; j < matrix.GetLength(1); j++)
                            {
                                Console.Write($"{matrix[i, j]} ");
                            }
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }

                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

                command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            }
        }
    }
}
