using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Supporting
    {
        public static bool Win(char[,] board, bool player1)
        {
            for (int i = 0; i < 3; i++)
            {
                if ((board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2] && board[i, 0] != ' ') || // Check rows
                            (board[0, i] == board[1, i] && board[1, i] == board[2, i] && board[0, i] != ' ') || // Check columns
                            (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] && board[0, 0] != ' ') || // Check main diagonal
                            (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0] && board[0, 2] != ' '))
                {
                    if (player1)
                    {
                        Console.WriteLine("player1 is the winner");
                    } else
                    {
                        Console.WriteLine("player2 is the winner");
                    }
                    
                    return true;
                }
            }
            
            return false;
        }

        public static void DisplayBoard(char[,] board)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Write('|');

                for (int c = 0; c < 3; c++)
                {
                    Console.Write(board[i, c].ToString() + '|');
                }
                Console.WriteLine();
            }
        }

        public static bool IsBoardFull(char[,] board)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int c = 0; c < 3; c++)
                {
                    if (board[i,c] == ' ')
                    {
                        return false;
                    }
                }
                
            }
            Console.WriteLine("its a tie");
            return true;
        }
    }
}


