using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Driver() {
        public static void Main()
        {
            Console.WriteLine("Welcome to Tic Tac Toe!");
            // Create a game board array to store the players' choices
            char[,] board = {
                            {' ', ' ', ' '},
                            {' ', ' ', ' '},
                            {' ', ' ', ' '}
                        };
            // Ask each player in turn for their choice and update the game board array
            bool player1 = true;
            do
            {
                //DisplayBoard(board);
                if (player1)
                {
                    Console.WriteLine("Player X, where would you like to play?");
                }
                else
                {
                    Console.WriteLine("Player O, where would you like to play?");
                }
                Console.WriteLine("Choose the row then the column. For example, '1,2' would select the Top Middle.");
                string input = Console.ReadLine();
                string[] inputParts = input.Split(',');
                int row = int.Parse(inputParts[0]);
                int col = int.Parse(inputParts[1]);
                if (/*ValidateInput(row, col) && */board[row, col] == ' ')
                {
                    board[row, col] = player1 ? 'X' : 'O';
                    player1 = !player1;
                }
                else
                {
                    Console.WriteLine("Invalid input or cell already taken. Try again.");
                }
                Supporting.DisplayBoard(board);
            } while (!Supporting.IsBoardFull(board) && !Supporting.Win(board, !player1));
        }
    }
}