using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_413___Mission_4
{
    internal class Support
    {
        public string[] PrintBoard(string[] board)
        {

            string[] gameBoard = ["   #   #   ",
                                  " {0}  # {1} # {2} ",
                                  "   #   #   ",
                                  "############",
                                  "   #   #   ",
                                  " {3} # {4} # {5} ",
                                  "   #   #   ",
                                  "############",
                                  "   #   #   ",
                                  " {6} # {7} # {8} ",
                                  "   #   #   "
            ];


            // Use string.Format to replace placeholders with values from the board array
            string formattedBoard = string.Format(gameBoard[1], board[0], board[1], board[2]);
            gameBoard[1] = formattedBoard;

            formattedBoard = string.Format(gameBoard[5], board[3], board[4], board[5]);
            gameBoard[5] = formattedBoard;

            formattedBoard = string.Format(gameBoard[9], board[6], board[7], board[8]);
            gameBoard[9] = formattedBoard; 

            return gameBoard;

       //     for (int input = 0; input < board.Length; input++)
        //    {
        //        // Assuming you want to copy the elements of 'board' to 'gameBoard'
//                gameBoard[input] = board[input];
//
     //       }

  //          return gameBoard;
        }

        static void Main(string[] args)
        {
            Support support = new Support();

            // Example usage: creating a board and printing it to the console
            string[] board = {"X", "X", "O", " ", " ", " ", "X", "X", "O" };
            string[] result = support.PrintBoard(board);

            // Print the result to the console
            foreach (var row in result)
            {
                Console.WriteLine(row);
            }
        }
    }
}
