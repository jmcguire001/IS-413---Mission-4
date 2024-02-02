using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_413___Mission_4
{
    internal class Support
    {
        // Method to print the game board
        public string PrintBoard(string[] board) //Parameters to receive: board, player 1, player 2, who is X
        {
            // Create the game board
            string gameBoard =
                $"   #   #   \n" +
                $" {board[0]} # {board[1]} # {board[2]} \n" +
                $"   #   #   \n" +
                "############\n" +
                $"   #   #   \n" +
                $" {board[3]} # {board[4]} # {board[5]} \n" +
                $"   #   #   \n" +
                "############\n" +
                $"   #   #   \n" +
                $" {board[6]} # {board[7]} # {board[8]} \n" +
                $"   #   #   ";

            // This still needs to evaluate for the winner
            return gameBoard;
        }

        // Method to check for a winner
        public string CheckWinner(string[] board, string player1Symbol, string player1Name, string player2Name)
        {
            // Initialize variables
            string winner = "";
            string Player1Symbol = player1Symbol;

            // Check for a winner
            if (board[0] == board[1] && board[1] == board[2] && board[0] != " ")
            {
                if (board[0] == Player1Symbol)
                {
                    winner = $"{player1Name} wins!";
                }
                else
                {
                    winner = $"{player2Name} wins!";
                }
            }
            else if (board[3] == board[4] && board[4] == board[5] && board[3] != " ")
            {
                if (board[3] == Player1Symbol)
                {
                    winner = $"{player1Name} wins!";
                }
                else
                {
                    winner = $"{player2Name} wins!";
                }
            }
            else if (board[6] == board[7] && board[7] == board[8] && board[6] != " ")
            {
                if (board[6] == Player1Symbol)
                {
                    winner = $"{player1Name} wins!";
                }
                else
                {
                    winner = $"{player2Name} wins!";
                }
            }
            else if (board[0] == board[3] && board[3] == board[6] && board[0] != " ")
            {
                if (board[0] == Player1Symbol)
                {
                    winner = $"{player1Name} wins!";
                }
                else
                {
                    winner = $"{player2Name} wins!";
                }
            }
            else if (board[1] == board[4] && board[4] == board[7] && board[1] != " ")
            {
                if (board[1] == Player1Symbol)
                {
                    winner = $"{player1Name} wins!";
                }
                else
                {
                    winner = $"{player2Name} wins!";
                }
            }
            else if (board[2] == board[5] && board[5] == board[8] && board[2] != " ")
            {
                if (board[2] == Player1Symbol)
                {
                    winner = $"{player1Name} wins!";
                }
                else
                {
                    winner = $"{player2Name} wins!";
                }
            }
            else if (board[0] == board[4] && board[4] == board[8] && board[0] != " ")
            {
                if (board[0] == Player1Symbol)
                {
                    winner = $"{player1Name} wins!";
                }
                else
                {
                    winner = $"{player2Name} wins!";
                }
            }
            else if (board[2] == board[4] && board[4] == board[6] && board[2] != " ")
            {
                if (board[2] == Player1Symbol)
                {
                    winner = $"{player1Name} wins!";
                }
                else
                {
                    winner = $"{player2Name} wins!";
                }
            }
            // Check for a cat's game or whether to continue
            else
            {
                // If the entire board is X or O, it's a cat's game
                if (board[0] != "1" && board[1] != "2" && board[2] != "3" && board[3] != "4" && board[4] != "5" && board[5] != "6" && board[6] != "7" && board[7] != "8" && board[8] != "9")
                {
                    winner = "Cat's game! No winner.";
                }
            }

            return winner;
        }
    }
}