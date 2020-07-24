using MinesweeperModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinesweeperGameConsoleApp 
{
    class Program 
    {

        static void Main(string[] args) 
        {
            // Initialize validity check.
            bool validDifficulty = false;
            int boardSize = 0;

            while (validDifficulty == false) 
            {
                // Get board size from user.
                Console.WriteLine("Choose your difficulty: Easy, Medium, or Hard");
                string difficultyString = Console.ReadLine();

                // Check user input is valid.
                if (difficultyString == "Easy" || difficultyString == "easy") 
                {
                    Console.WriteLine("You chose easy!");
                    validDifficulty = true;
                    boardSize = 10;
                } 
                else if (difficultyString == "Medium" || difficultyString == "medium") 
                {
                    Console.WriteLine("You chose medium!");
                    validDifficulty = true;
                    boardSize = 16;
                } 
                else if (difficultyString == "Hard" || difficultyString == "hard") 
                {
                    Console.WriteLine("You chose hard!");
                    validDifficulty = true;
                    boardSize = 20;
                } 
                else 
                {
                    Console.WriteLine("Sorry, that is not a valid difficulty!");
                }
            }
            
            // Initialize the minesweeper board.
            Board myBoard = new Board(boardSize);

            // Show the empty Minesweeper board.
            printBoard(myBoard);

            // Ends program after key press.
            Console.ReadLine();
        }

        private static void printBoard(Board myBoard) 
        {
            // Print the minesweeper board. * are bombs.
            for (int i = 0; i < (myBoard.Size * 2) + 3; i++) 
            {
                if (i == 0) 
                {
                    // Top edge of board.
                    for (int j = 0; j < myBoard.Size; j++) 
                    {
                        Console.Write("====");
                    }
                    Console.Write("=");
                } 
                else if (i == (myBoard.Size * 2) + 2)
                {
                    // Bottom edge of board.
                    for (int j = 0; j < myBoard.Size; j++) 
                    {
                        Console.Write("====");
                    }
                    Console.Write("=");
                } 
                else 
                {
                    if ((i) % 2 == 1) 
                    {
                        for (int j = 0; j < myBoard.Size; j++) 
                        {
                            Console.Write("+---");
                        }
                        Console.Write("+");
                    }
                    if ((i) % 2 == 0) 
                    {
                        for (int j = 0; j < myBoard.Size; j++) 
                        {
                            Console.Write("|   ");
                        }
                        Console.Write("|");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
