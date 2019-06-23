using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _04_SymbolInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int dim = int.Parse(Console.ReadLine());

            char[,] matrix = new char[dim, dim];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                char[] tokens = Console.ReadLine()
                    .ToCharArray();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = tokens[j];
                }
            }

            char charToMatch = Console.ReadLine()[0];
            bool match = false;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i,j] == charToMatch)
                    {
                        match = true;
                        Console.WriteLine((i, j));
                    }
                }
            }

            if (!match)
            {
                Console.WriteLine($"{charToMatch} does not occur in the matrix");
            }
        }
    }
}
