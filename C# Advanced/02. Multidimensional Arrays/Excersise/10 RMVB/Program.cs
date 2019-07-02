using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _10_RMVB
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            char[,] field = new char[size[0], size[1]];

            int currentRow = -1;
            int currentCol = -1;

            var bunniesLocation = new List<int[]>();

            for (int row = 0; row < field.GetLength(0); row++)
            {
                char[] tokens = Console.ReadLine()
                    .Replace(" ", "")
                    .ToCharArray();
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    field[row, col] = tokens[col];
                    if (field[row, col] == 'P')
                    {
                        currentRow = row;
                        currentCol = col;
                    }
                    else if (field[row, col] == 'B')
                    {
                        int[] currentLoc = new int[] { row, col };
                        bunniesLocation.Add(currentLoc);
                    }
                }
            }

            char[] commands = Console.ReadLine().ToCharArray();
            bool won = false;
            bool playerStepOnRMVB = false;
            bool RMVBStepOnPlayer = false;

            for (int i = 0; i < commands.Length; i++)
            {
                char currentCommand = commands[i];
                if (currentCommand == 'L') //move player to the left
                {
                    if (IsInside(field, currentRow, currentCol - 1))
                    {
                        field[currentRow, currentCol] = '.';
                        currentCol -= 1;
                        if (field[currentRow, currentCol] == 'B')
                        {
                            playerStepOnRMVB = true;
                        }
                        else
                        {
                            field[currentRow, currentCol] = 'P';
                        }
                    }
                    else
                    {
                        field[currentRow, currentCol] = '.';
                        won = true;
                    }

                }
                else if (currentCommand == 'R') // move player to the right
                {
                    if (IsInside(field, currentRow, currentCol + 1))
                    {
                        field[currentRow, currentCol] = '.';
                        currentCol += 1;
                        if (field[currentRow, currentCol] == 'B')
                        {
                            playerStepOnRMVB = true;
                        }
                        else
                        {
                            field[currentRow, currentCol] = 'P';
                        }
                    }
                    else
                    {
                        field[currentRow, currentCol] = '.';
                        won = true;
                    }
                }
                else if (currentCommand == 'U') // move player up
                {
                    if (IsInside(field, currentRow - 1, currentCol))
                    {
                        field[currentRow, currentCol] = '.';
                        currentRow -= 1;
                        if (field[currentRow, currentCol] == 'B')
                        {
                            playerStepOnRMVB = true;
                        }
                        else
                        {
                            field[currentRow, currentCol] = 'P';
                        }
                    }
                    else
                    {
                        field[currentRow, currentCol] = '.';
                        won = true;
                    }
                }
                else if (currentCommand == 'D') // move player down
                {
                    if (IsInside(field, currentRow + 1, currentCol))
                    {
                        field[currentRow, currentCol] = '.';
                        currentRow += 1;
                        if (field[currentRow, currentCol] == 'B')
                        {
                            playerStepOnRMVB = true;
                        }
                        else
                        {
                            field[currentRow, currentCol] = 'P';
                        }
                    }
                    else
                    {
                        won = true;
                    }
                }
                //end of player move
                int currentBunniesCount = bunniesLocation.Count;
                //for (int j = 0; j < currentBunniesCount; j++)
                //{

                //}
                if (!playerStepOnRMVB)
                {

                }
                for (int j = 0; j < currentBunniesCount; j++)
                {
                    int[] location = bunniesLocation[j];
                    int bunnyRow = location[0];
                    int bunnyCol = location[1];
                    if (IsInside(field, bunnyRow, bunnyCol - 1)) // bunny multiplies to the left
                    {
                        if (field[bunnyRow, bunnyCol - 1] == 'P') // check if player is already in that cell
                        {
                            RMVBStepOnPlayer = true;
                            field[bunnyRow, bunnyCol - 1] = 'B';
                        }
                        else if (field[bunnyRow, bunnyCol - 1] != 'B')
                        {
                            field[bunnyRow, bunnyCol - 1] = 'B'; // add bunny to the left
                            int[] currentLoc = new int[] { bunnyRow, bunnyCol - 1 };
                            bunniesLocation.Add(currentLoc);
                        }
                    }
                    if (IsInside(field, bunnyRow, bunnyCol + 1)) // bunny multiplies to the Right
                    {
                        if (field[bunnyRow, bunnyCol + 1] == 'P') // check if player is already in that cell
                        {
                            RMVBStepOnPlayer = true;
                            field[bunnyRow, bunnyCol + 1] = 'B';
                        }
                        else if (field[bunnyRow, bunnyCol + 1] != 'B')
                        {
                            field[bunnyRow, bunnyCol + 1] = 'B'; // add bunny to the right
                            int[] currentLoc = new int[] { bunnyRow, bunnyCol + 1 };
                            bunniesLocation.Add(currentLoc);
                        }
                    }
                    if (IsInside(field, bunnyRow - 1, bunnyCol)) // bunny multiplies to the top cell
                    {
                        if (field[bunnyRow - 1, bunnyCol] == 'P') // check if player is already in that cell
                        {
                            RMVBStepOnPlayer = true;
                            field[bunnyRow - 1, bunnyCol] = 'B';
                        }
                        else if (field[bunnyRow - 1, bunnyCol] != 'B')
                        {
                            field[bunnyRow - 1, bunnyCol] = 'B'; // add bunny to the top cell
                            int[] currentLoc = new int[] { bunnyRow - 1, bunnyCol };
                            bunniesLocation.Add(currentLoc);
                        }
                    }
                    if (IsInside(field, bunnyRow + 1, bunnyCol)) // bunny multiplies to the bottom cell
                    {
                        if (field[bunnyRow + 1, bunnyCol] == 'P') // check if player is already in that cell
                        {
                            RMVBStepOnPlayer = true;
                            field[bunnyRow + 1, bunnyCol] = 'B';
                        }
                        else if (field[bunnyRow + 1, bunnyCol] != 'B')
                        {
                            field[bunnyRow + 1, bunnyCol] = 'B'; // add bunny to the bottom cell
                            int[] currentLoc = new int[] { bunnyRow + 1, bunnyCol };
                            bunniesLocation.Add(currentLoc);
                        }
                    }

                }
                if (won)
                {
                    PrintField(field);
                    Console.WriteLine($"won: {currentRow} {currentCol}");
                    break;
                }
                if (playerStepOnRMVB || RMVBStepOnPlayer)
                {
                    PrintField(field);
                    Console.WriteLine($"dead: {currentRow} {currentCol}");
                    break;
                }
            }
        }

        private static void PrintField(char[,] field)
        {
            for (int row = 0; row < field.GetLength(0); row++)
            {
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    Console.Write($"{field[row, col]}");
                }
                Console.WriteLine();
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
