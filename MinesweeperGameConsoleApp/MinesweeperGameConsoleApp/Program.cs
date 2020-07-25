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
            int percentageBombs = 0;

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
                    percentageBombs = 8;
                } 
                else if (difficultyString == "Medium" || difficultyString == "medium") 
                {
                    Console.WriteLine("You chose medium!");
                    validDifficulty = true;
                    boardSize = 16;
                    percentageBombs = 12;
                } 
                else if (difficultyString == "Hard" || difficultyString == "hard") 
                {
                    Console.WriteLine("You chose hard!");
                    validDifficulty = true;
                    boardSize = 20;
                    percentageBombs = 20;
                } 
                else 
                {
                    Console.WriteLine("Sorry, that is not a valid difficulty!");
                }
            }
            
            // Initialize the minesweeper board.
            Board myBoard = new Board(boardSize);

            // Set difficulty
            myBoard.Difficulty = percentageBombs;

            // Populate the game with bombs.
            int bombCount = myBoard.PlantBombs();

            // Calculate turns until the player wins.
            int totalMoves = boardSize * boardSize;
            int winningMoves = totalMoves - bombCount;

            // Show the planted Minesweeper board.
            printBoard(myBoard);

            // Starts the game loop.
            bool gameFinished = false;

            while (!gameFinished)
            {
                // Prompt user for place to visit.
                Cell currentCell = checkCurrentCell(myBoard);

                // Counts towards progress if first visit.
                if (currentCell.Visited == false) 
                { 
                    winningMoves--; 
                }

                // Marks cell has been visited before.
                currentCell.Visited = true;

                // Show the updated Minesweeper board.
                printBoard(myBoard);

                // Tells user how many bombs to go.
                Console.WriteLine("Spots to clear: " + winningMoves);

                // Checks if location contains bomb.
                if (currentCell.ContainsBomb == true)
                {
                    Console.WriteLine("Oh no, there is a bomb here.");
                    Console.WriteLine(" :( ");
                    gameFinished = true;
                } 
                else if (winningMoves == 0)
                {
                    Console.WriteLine("You cleared all the bombs!");
                    Console.WriteLine(" :) ");
                    gameFinished = true;
                } 
                else
                {
                    gameFinished = false;
                }
 
            }

            // Ends program after key press.
            Console.ReadLine();
        }

        private static void printBoard(Board myBoard) 
        {
            // Print the minesweeper board. * are bombs.
            for (int i = 0; i < (myBoard.Size * 2) + 3; i++) 
            {
                int topEdge = i - 3;

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
                            int k = ((topEdge + 2) / 2);

                            Cell c = myBoard.theGrid[k, j];

                            if (c.Visited == false) 
                            {
                                Console.Write("| ? ");
                            } 
                            else 
                            {
                                if (c.ContainsBomb == true) 
                                {
                                    Console.Write("| * ");
                                } 
                                else 
                                {
                                    c.LiveNeighbors = myBoard.CalculateLiveNeighbors(k, j);

                                    if (c.LiveNeighbors == 0) 
                                    {
                                        Console.Write("|   ");
                                    }
                                    else 
                                    {
                                        Console.Write("| " + c.LiveNeighbors + " ");
                                    }
                                }
                            }
                        }
                        Console.Write("|");
                    }
                }
                Console.WriteLine();
            }
        }

        private static Cell checkCurrentCell(Board myBoard)
        {
            // Default values for current cell.
            int currentRow = 0;
            int currentColumn = 0;

            // Validity of input boolean.
            bool validRow = false;
            bool validColumn = false;

            // Ask user for x and y coordinates. Check validity of user input. Return a cell location for valid input.
            while (validRow == false || validColumn == false) 
            {
                // Default values for current cell.
                currentRow = 0;
                currentColumn = 0;

                // Get user inputs.
                Console.WriteLine("Enter the row number: ");
                string currentRowString = Console.ReadLine();
                try 
                {
                    currentRow = int.Parse(currentRowString) - 1;
                    if (currentRow >= 0 && currentRow <= myBoard.Size - 1) 
                    {
                        validRow = true;
                    } 
                    else 
                    {
                        Console.WriteLine("Value out of range. Please input valid values.");
                    }
                } 
                catch
                {
                    Console.WriteLine("Invalid input for row (integer only).");
                }


                Console.WriteLine("Enter the column number: ");
                string currentColumnString = Console.ReadLine();
                try 
                {
                    currentColumn = int.Parse(currentColumnString) - 1;
                    if (currentColumn >= 0 && currentColumn <= myBoard.Size - 1)
                    {
                        validColumn = true;
                    }
                    else 
                    {
                        Console.WriteLine("Value out of range. Please input valid values.");
                    }
                } 
                catch 
                {
                    Console.WriteLine("Invalid input for column (integer only).");
                }
            }
            return myBoard.theGrid[currentRow, currentColumn];
        }
    }
}
