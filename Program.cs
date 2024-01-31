using System.Runtime.InteropServices;
using System.Xml.Serialization;

// Group 2-3: Driver Class

internal class Program
{
    private static void Main(string[] args)
    {
        int choice = 0;
        string symbolP1 = "";
        string symbolP2 = "";
        int player = 1;


        // Welcome the user to the game
        Console.WriteLine("Welcome to our Tic-Tac-Toe game! ");

        Console.WriteLine("Player 1: Do you want to be xs or os? ");
        symbolP1 = Console.ReadLine().ToLower();
        if (symbolP1 == "x")
        {
            symbolP2 = "o";
        }
        else if (symbolP1 == "o")
        {
            symbolP2 = "x";
        }
        else
        {
            Console.WriteLine("Please enter either x or o.");
        }

        // Create a game board array to store the players’ choices
        string[] board = new string[9];

        // Ask each player in turn for their choice and update the game board array
        for (int i = 0; i < 9; i++)
        {
            if (player == 1)
            {
                Console.WriteLine($"Player {player}, your move! Enter the number 1-9 where you want your {symbolP1} to go ");
                choice = int.Parse(Console.ReadLine());
                board[(choice - 1)] = symbolP1;
                player = 2;
            }
            else if (player == 2)
            {
                Console.WriteLine($"Player {player}, your move! Enter the number 1-9 where you want your {symbolP2} to go ");
                choice = int.Parse(Console.ReadLine());
                board[(choice - 1)] = symbolP2;
                player = 1;
            }
            Console.WriteLine(board);
        }

        

        // Print the board by calling the method in the supporting class
        // PrintBoard();
    }
}


// Check for a winner by calling the method in the supporting class

// Notify the players when a win has occurred and which player won the game