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
        string symbol = "X";
        string name = "";
        bool winner = false;
        bool valid = false;
        string winnerName = "";
        bool check = true;
        string player1Name = "";
        string player2Name = "";
        int player = 0;
        string pass = "";
        string passname1 = "";
        string passname2 = "";

        // Welcome the user to the game
        Console.WriteLine("Welcome to our Tic-Tac-Toe game! ");

        while (check)
        {
            Console.WriteLine("Player 1: What is your name?");
            player1Name = Console.ReadLine();

            Console.WriteLine("Player 2: What is your name?");
            player2Name = Console.ReadLine();

            Console.WriteLine($"{player1Name}, Do you want to be Xs or Os? ");
            symbolP1 = Console.ReadLine().ToUpper();
            if (symbolP1 == "X")
            {
                player = 1;
                name = player1Name;
                symbolP2 = "O";
                check = false;
                pass = symbolP1;
                passname1 = player1Name;
                passname2 = player2Name;

            }
            else if (symbolP1 == "O")
            {
                player = 2;
                name = player2Name;
                symbolP2 = "X";
                pass = symbolP2;
                check = false;
                passname1 = player2Name;
                passname2 = player1Name;
            }
            else
            {
                Console.WriteLine("Please enter either X or O.");
            }
        }
        

        // Create a game board array to store the players’ choices
        string[] board = new string[9];
        
        
        for (int iCount = 0; iCount < board.Length; ++iCount)
        {
            board[iCount] = $"{iCount + 1}";
        }

        Console.WriteLine(s.PrintBoard(board));
        // Ask each player in turn for their choice and update the game board array

        for (int i = 0; i < 9; i++)
        {
            while (winner == false)
            {
                if (player == 1)
                {
                    Console.WriteLine($"{name}, your move! Enter the number 1-9 where you want your {symbol} to go ");
                    choice = int.Parse(Console.ReadLine());
                    // Validate choice
                    string elementToCheck = board[(choice - 1)];
                    valid = int.TryParse(elementToCheck, out int result);

                    if (valid == true) 
                    {
                        board[(choice - 1)] = symbolP1;
                        player = 2;
                        name = player2Name;
                        symbol = symbolP2;
                        // Print the board by calling the method in the supporting class
                        Console.WriteLine(s.PrintBoard(board));

                        // Check for a winner by calling the method in the supporting class
                        winnerName = s.CheckWinner(board, pass, passname1, passname2);
                        // Console.WriteLine(winnerName);
                        if (winnerName != "")
                        {
                            winner = true;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Position already taken. Try again ");
                        i--;
                    }
                }
                else if (player == 2)
                {
                    Console.WriteLine($"{name}, your move! Enter the number 1-9 where you want your {symbol} to go ");
                    choice = int.Parse(Console.ReadLine());
                    
                    // Validate choice
                    string elementToCheck = board[(choice - 1)];
                    valid = int.TryParse(elementToCheck, out int result);

                    if (valid == true)
                    {
                        board[(choice - 1)] = symbolP2;
                        player = 1;
                        name = player1Name;
                        symbol = symbolP1;
                        // Print the board by calling the method in the supporting class
                        Console.WriteLine(s.PrintBoard(board));

                        // Check for a winner by calling the method in the supporting class
                        winnerName = s.CheckWinner(board, pass, passname1, passname2);
                        // Console.WriteLine(winnerName);
                        if (winnerName != "")
                        {
                            winner = true;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Position already taken. Try again ");
                        i--;
                    }
                }
            }
        }
        // Notify the players when a win has occurred and which player won the game
        Console.WriteLine(winnerName);
    }
}