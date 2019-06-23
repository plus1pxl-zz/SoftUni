using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _06_JaggedArrayModification
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] jaggedArray = new int[rows][];

            for (int i = 0; i < rows; i++)
            {
                int[] numbers = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                jaggedArray[i] = numbers;
            }

            string command = Console.ReadLine();

            while (command?.ToLower() != "end")
            {
                string[] tokens = command.Split();
                string operation = tokens[0].ToLower();
                int row = int.Parse(tokens[1]);
                int col = int.Parse(tokens[2]);
                int value = int.Parse(tokens[3]);

                if (row < 0 
                    || row >= rows 
                    || col < 0 
                    || col > jaggedArray[row].Length)
                {
                    Console.WriteLine("Invalid coordinates");
                }
                else
                {
                    if (operation == "add")
                    {
                        jaggedArray[row][col] += value;
                    }
                    else if (operation == "subtract")
                    {
                        jaggedArray[row][col] -= value;
                    }
                }

                command = Console.ReadLine();
            }

            foreach (var item in jaggedArray)
            {
                Console.WriteLine(String.Join(" ", item));
            }
        }
    }
}
