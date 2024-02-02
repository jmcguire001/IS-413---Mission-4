using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;
using IS_413___Mission_4;

// Group 2-3: Driver Class

internal class Program
{
    private static void Main(string[] args)
    {
        Support s = new Support();

        int choice = 0;
        string symbolP1 = "";
        string symbolP2 = "";
        int player = 1;


        // Welcome the user to the game
        Console.WriteLine("Welcome to our Tic-Tac-Toe game! ");

        Console.WriteLine("Player 1: Do you want to be Xs or Os? ");
        symbolP1 = Console.ReadLine().ToUpper();
        if (symbolP1 == "X")
        {
            symbolP2 = "O";
        }
        else if (symbolP1 == "O")
        {
            symbolP2 = "X";
        }
        else
        {
            Console.WriteLine("Please enter either X or O.");
        }

        // Create a game board array to store the players’ choices
        string[] board = new string[9];
        for (int iCount = 0; iCount < board.Length; ++iCount)
        {
            board[iCount] = " ";
        }

        // Ask each player in turn for their choice and update the game board array
        for (int i = 0; i < 9; i++)
        {
            if (player == 1)
            {
                Console.WriteLine($"Player {player}, your move! Enter the number 1-9 where you want your {symbolP1} to go ");
                choice = int.Parse(Console.ReadLine());
                // Validate choice
                if (board[choice - 1] == " ")
                {
                    board[(choice - 1)] = symbolP1;
                    player = 2;
                }
                else
                {
                    Console.WriteLine("Position already taken. Try again ");
                    i--;
                }
            }
            else if (player == 2)
            {
                Console.WriteLine($"Player {player}, your move! Enter the number 1-9 where you want your {symbolP2} to go ");
                choice = int.Parse(Console.ReadLine());

                if (board[choice - 1] == " ")
                {
                    board[(choice - 1)] = symbolP2;
                    player = 1;
                }
                else
                {
                    Console.WriteLine("Position already taken. Try again ");
                    i--;
                }
            }
            // Print the board by calling the method in the supporting class
            Console.WriteLine(s.PrintBoard());

            // Check for a winner by calling the method in the supporting class
            // s.CheckWinner();
        }
        string winner = "";
        // Notify the players when a win has occurred and which player won the game
        Console.WriteLine($"Player {winner} has won! Good game ");
    }

}