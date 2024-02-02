using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_413___Mission_4
{
    internal class Support
    {
        public string PrintBoard(string[] board) //Parameters to receive: board, player 1, player 2, who is X
        {
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

        public string CheckWinner(string[] board, string player1)
        {
            string winner = "";
            string Player1 = player1;

            // Check for a winner
            if (board[0] == board[1] && board[1] == board[2] && board[0] != " ")
            {
                if (board[0] == Player1)
                {
                    winner = "Player 1 has won. Good game!";
                }
                else
                {
                    winner = "Player 2 has won. Good game!";
                }
            }
            else if (board[3] == board[4] && board[4] == board[5] && board[3] != " ")
            {
                if (board[3] == Player1)
                {
                    winner = "Player 1 has won. Good game!";
                }
                else
                {
                    winner = "Player 2 has won. Good game!";
                }
            }
            else if (board[6] == board[7] && board[7] == board[8] && board[6] != " ")
            {
                if (board[6] == Player1)
                {
                    winner = "Player 1 has won. Good game!";
                }
                else
                {
                    winner = "Player 2 has won. Good game!";
                }
            }
            else if (board[0] == board[3] && board[3] == board[6] && board[0] != " ")
            {
                if (board[0] == Player1)
                {
                    winner = "Player 1 has won. Good game!";
                }
                else
                {
                    winner = "Player 2 has won. Good game!";
                }
            }
            else if (board[1] == board[4] && board[4] == board[7] && board[1] != " ")
            {
                if (board[1] == Player1)
                {
                    winner = "Player 1 has won. Good game!";
                }
                else
                {
                    winner = "Player 2 has won. Good game!";
                }
            }
            else if (board[2] == board[5] && board[5] == board[8] && board[2] != " ")
            {
                if (board[2] == Player1)
                {
                    winner = "Player 1 has won. Good game!";
                }
                else
                {
                    winner = "Player 2 has won. Good game!";
                }
            }
            else if (board[0] == board[4] && board[4] == board[8] && board[0] != " ")
            {
                if (board[0] == Player1)
                {
                    winner = "Player 1 has won. Good game!";
                }
                else
                {
                    winner = "Player 2 has won. Good game!";
                }
            }
            else if (board[2] == board[4] && board[4] == board[6] && board[2] != " ")
            {
                if (board[2] == Player1)
                {
                    winner = "Player 1 has won. Good game!";
                }
                else
                {
                    winner = "Player 2 has won. Good game!";
                }
            }
            else
            {
                winner = "Cat's game! No winner.";
            }

            return winner;
        }
    }
}