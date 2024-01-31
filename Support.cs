using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_413___Mission_4
{
    internal class Support
    {
        public string PrintBoard(string[] board)
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

            return gameBoard;
        }

        static void Main(string[] args)
        {
            Support support = new Support();

            // Example usage: creating a board and printing it to the console
            string[] board = { "X", "X", " ", "X", "X", "X", " ", "X", "O" };
            string result = support.PrintBoard(board);

            // Print the result to the console
            Console.WriteLine(result);
        }
    }
}