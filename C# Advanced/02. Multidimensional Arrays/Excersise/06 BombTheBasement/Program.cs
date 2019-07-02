using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _06_BombTheBasement
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[,] basement = new int[size[0], size[1]];

            int[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int targetRow = tokens[0];
            int targetCol = tokens[1];
            int radius = tokens[2];

            for (int row = 0; row < basement.GetLength(0); row++)
            {
                for (int col = 0; col < basement.GetLength(1); col++)
                {
                    bool isInRadius = Math.Pow(row - targetRow, 2) + Math.Pow(col - targetCol, 2) <= Math.Pow(radius, 2);
                    if (isInRadius)
                    {
                        basement[row, col] = 1;
                    }
                }
            }

            for (int i = 1; i < basement.GetLength(1); i++)
            {
                for (int row = 1; row < basement.GetLength(0); row++)
                {
                    for (int col = 0; col < basement.GetLength(1); col++)
                    {
                        if (basement[row, col] == 1 && basement[row - 1, col] == 0)
                        {
                            basement[row, col] = 0;
                            basement[row - 1, col] = 1;
                        }
                    }
                }
            }



            for (int row = 0; row < basement.GetLength(0); row++)
            {
                for (int col = 0; col < basement.GetLength(1); col++)
                {
                    Console.Write(basement[row,col]);
                }
                Console.WriteLine();
            }
        }
    }
}
