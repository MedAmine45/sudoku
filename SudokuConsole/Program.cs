using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuConsole
{
    public  class Program
    {
        static void Main(string[] args)
        {
            int[,] board = {
            {0, 0, 0, 0, 0, 4, 5, 3, 1},
            {8, 3, 1, 0, 0, 7, 6, 0, 9},
            {5, 4, 9, 0, 0, 0, 8, 0, 7},
            {0, 2, 0, 5, 0, 1, 0, 7, 0},
            {4, 1, 0, 0, 0, 0, 9, 6, 0},
            {0, 6, 3, 0, 2, 0, 0, 0, 0},
            {0, 0, 0, 0, 3, 0, 4, 9, 6},
            {0, 9, 0, 7, 4, 0, 0, 1, 0},
            {2, 8, 0, 0, 0, 6, 7, 0, 0}
        };

            if (SolveSudoku(board))
            {
                Console.WriteLine("Sudoku solved successfully:");
                PrintBoard(board);
            }
            else
            {
                Console.WriteLine("No solution exists for the given Sudoku.");
            }

            Console.ReadLine();
        }

        public static bool SolveSudoku(int[,] board)
        {
            int row = 0;
            int col = 0;
            bool isEmpty = true;

         
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (board[i, j] == 0)
                    {
                        row = i;
                        col = j;
                        isEmpty = false;
                        break;
                    }
                }
                if (!isEmpty)
                {
                    break;
                }
            }

            
            if (isEmpty)
            {
                return true;
            }

            for (int num = 1; num <= 9; num++)
            {
                if (IsSafe(board, row, col, num))
                {
                    board[row, col] = num;

                  
                    if (SolveSudoku(board))
                    {
                        return true;
                    }

                    board[row, col] = 0;
                }
            }

            return false;
        }

        private static bool IsSafe(int[,] board, int row, int col, int num)
        {
            for (int i = 0; i < 9; i++)
            {
                if (board[row, i] == num)
                {
                    return false;
                }
            }

         
            for (int i = 0; i < 9; i++)
            {
                if (board[i, col] == num)
                {
                    return false;
                }
            }

           
            int boxStartRow = row - row % 3;
            int boxStartCol = col - col % 3;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[boxStartRow + i, boxStartCol + j] == num)
                    {
                        return false;
                    }
                }
            }

            return true;
        }


        public static void PrintBoard(int[,] board)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Console.Write(board[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

    }
}
