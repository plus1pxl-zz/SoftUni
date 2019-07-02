using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _09_Miner
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int coalsCount = 0;
            int coalsCollected = 0;
            int currentRow = -1;
            int currentCol = -1;

            int size = int.Parse(Console.ReadLine());
            char[,] field = new char[size, size];
            string[] commands = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            for (int i = 0; i < field.GetLength(0); i++)
            {
                char[] tokens = Console.ReadLine()
                    .Replace(" ", "")
                    .ToCharArray();

                for (int j = 0; j < field.GetLength(1); j++)
                {
                    field[i, j] = tokens[j];
                    if (field[i, j] == 'c')
                    {
                        coalsCount++;
                    }
                    else if (field[i, j] == 's')
                    {
                        currentRow = i;
                        currentCol = j;
                    }
                }
            }
            bool printRemainingCoals = true;
            if (currentCol >= 0 && currentRow >= 0)
            {
                for (int i = 0; i < commands.Length; i++)
                {
                    string currentCommand = commands[i];
                    if (currentCommand?.ToLower() == "left")
                    {
                        if (IsInside(field, currentRow, currentCol - 1))
                        {
                            currentCol -= 1;
                            if (field[currentRow, currentCol] == 'e')
                            {
                                Console.WriteLine($"Game over! ({currentRow}, {currentCol})");
                                printRemainingCoals = false;
                                break;
                            }
                            else if (field[currentRow, currentCol] == 'c')
                            {
                                coalsCollected++;
                                field[currentRow, currentCol] = '*';
                                if (coalsCollected == coalsCount)
                                {
                                    Console.WriteLine($"You collected all coals! ({currentRow}, {currentCol})");
                                    printRemainingCoals = false;
                                    break;
                                }
                            }
                        }
                    }
                    if (currentCommand?.ToLower() == "right")
                    {
                        if (IsInside(field, currentRow, currentCol + 1))
                        {
                            currentCol += 1;
                            if (field[currentRow, currentCol] == 'e')
                            {
                                Console.WriteLine($"Game over! ({currentRow}, {currentCol})");
                                printRemainingCoals = false;
                                break;
                            }
                            else if (field[currentRow, currentCol] == 'c')
                            {
                                coalsCollected++;
                                field[currentRow, currentCol] = '*';
                                if (coalsCollected == coalsCount)
                                {
                                    Console.WriteLine($"You collected all coals! ({currentRow}, {currentCol})");
                                    printRemainingCoals = false;
                                    break;
                                }
                            }
                        }
                    }
                    if (currentCommand?.ToLower() == "up")
                    {
                        if (IsInside(field, currentRow - 1, currentCol))
                        {
                            currentRow -= 1;
                            if (field[currentRow, currentCol] == 'e')
                            {
                                Console.WriteLine($"Game over! ({currentRow}, {currentCol})");
                                printRemainingCoals = false;
                                break;
                            }
                            else if (field[currentRow, currentCol] == 'c')
                            {
                                coalsCollected++;
                                field[currentRow, currentCol] = '*';
                                if (coalsCollected == coalsCount)
                                {
                                    Console.WriteLine($"You collected all coals! ({currentRow}, {currentCol})");
                                    printRemainingCoals = false;
                                    break;
                                }
                            }
                        }
                    }
                    if (currentCommand?.ToLower() == "down")
                    {
                        if (IsInside(field, currentRow + 1, currentCol))
                        {
                            currentRow += 1;
                            if (field[currentRow, currentCol] == 'e')
                            {
                                Console.WriteLine($"Game over! ({currentRow}, {currentCol})");
                                printRemainingCoals = false;
                                break;
                            }
                            else if (field[currentRow, currentCol] == 'c')
                            {
                                coalsCollected++;
                                field[currentRow, currentCol] = '*';
                                if (coalsCollected == coalsCount)
                                {
                                    Console.WriteLine($"You collected all coals! ({currentRow}, {currentCol})");
                                    printRemainingCoals = false;
                                    break;
                                }
                            }
                        }
                    }

                }
            }
            if (printRemainingCoals)
            {
                int coalsRemaining = coalsCount - coalsCollected;
                Console.WriteLine($"{coalsRemaining} coals left. ({currentRow}, {currentCol})");
            }


        }

        private static bool IsInside(char[,] field, int desiredRow, int desiredCol)
        {
            return desiredRow < field.GetLength(0)
                && desiredRow >= 0
                && desiredCol < field.GetLength(1)
                && desiredCol >= 0;
        }
    }
}
