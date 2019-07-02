using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _07_KnightGame
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] board = new char[size, size];

            for (int i = 0; i < board.GetLength(0); i++)
            {
                char[] tokens = Console.ReadLine().ToCharArray();

                for (int j = 0; j < board.GetLength(1); j++)
                {
                    board[i, j] = tokens[j];
                }
            }

            int knightCount = 0;
            int removedKnightCount = 0;

            for (int row = 0; row < board.GetLength(0); row++)
            {
                for (int col = 0; col < board.GetLength(1); col++)
                {
                    if (board[row, col] == 'K')
                    {
                        knightCount++;
                    }
                }
            }

            for (int i = 0; i < knightCount; i++)
            {
                int maxAttacks = -1;
                int currentRow = -1;
                int currentCol = -1;

                for (int row = 0; row < board.GetLength(0); row++)
                {
                    for (int col = 0; col < board.GetLength(1); col++)
                    {
                        int currentAttacks = 0;
                        if (board[row, col] == 'K')
                        {
                            if (IsInside(board, row -2, col + 1) && board[row - 2, col +1] == 'K')
                            {
                                currentAttacks++;
                            }
                            if (IsInside(board, row - 2, col - 1) && board[row - 2, col - 1] == 'K')
                            {
                                currentAttacks++;
                            }
                            if (IsInside(board, row + 2, col + 1) && board[row + 2, col + 1] == 'K')
                            {
                                currentAttacks++;
                            }
                            if (IsInside(board, row + 2, col - 1) && board[row + 2, col - 1] == 'K')
                            {
                                currentAttacks++;
                            }
                            if (IsInside(board, row - 1, col - 2) && board[row - 1, col - 2] == 'K')
                            {
                                currentAttacks++;
                            }
                            if (IsInside(board, row + 1, col - 2) && board[row + 1, col - 2] == 'K')
                            {
                                currentAttacks++;
                            }
                            if (IsInside(board, row - 1, col + 2) && board[row - 1, col + 2] == 'K')
                            {
                                currentAttacks++;
                            }
                            if (IsInside(board, row + 1, col + 2) && board[row + 1, col + 2] == 'K')
                            {
                                currentAttacks++;
                            }
                            if (currentAttacks > maxAttacks)
                            {
                                maxAttacks = currentAttacks;
                                currentCol = col;
                                currentRow = row;
                            }
                        }
                    }
                }

                if (maxAttacks > 0)
                {
                    board[currentRow, currentCol] = '0';
                    removedKnightCount++;
                }
            }

            Console.WriteLine(removedKnightCount);
        }

        private static bool IsInside(char[,] board, int desiredRow, int desiredCol)
        {
            return desiredRow < board.GetLength(0) 
                && desiredRow >= 0 
                && desiredCol < board.GetLength(1) 
                && desiredCol >= 0;
        }
    }
}
