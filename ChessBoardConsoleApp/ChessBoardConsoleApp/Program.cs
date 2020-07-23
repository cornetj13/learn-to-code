using ChessBoardModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoardConsoleApp 
{
    class Program 
    {
        // Initialize the chess board.
        static Board myBoard = new Board(8);

        static void Main(string[] args) 
        {
            // Show the empty Chess board.
            printBoard(myBoard);

            // Ask the user for the position of the piece (x and y coordinate).
            Cell currentCell = setCurrentCell();
            currentCell.CurrentlyOccupied = true;

            // Ask the user for the appropriate piece name.
            Console.WriteLine("Which piece would you like to place on the board? (Bishop, King, Knight, Queen, or Rook)");
            string pieceString = Console.ReadLine();

            // Calcualte all legal moves for the piece.
            myBoard.MarkNextLegalMoves(currentCell, pieceString);

            // Print the chess board displaying the piece and it's legal moves.
            // X will represent the piece occupying the cell.
            // + will represent the legal moves.
            // . will represent an empty cell.
            printBoard(myBoard);


            // Ends program after key press.
            Console.ReadLine();

        }

        private static Cell setCurrentCell()
        {
            // Default values for current cell.
            int currentRow = 3;
            int currentColumn = 3;

            // Validity of input boolean.
            bool validRow = false;
            bool validColumn = false;

            // Ask user for x and y coordinates. Check validity of user input. Return a cell location for valid input.
            while (validRow == false || validColumn == false) 
            {
                // Default values for current cell.
                currentRow = 3;
                currentColumn = 3;

                // Get user inputs.
                Console.WriteLine("Enter the row number");
                string currentRowString = Console.ReadLine();
                try 
                {
                    currentRow = int.Parse(currentRowString) - 1;
                    if (currentRow >= 0 && currentRow <= myBoard.Size - 3) 
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
                    Console.WriteLine("Invalid input for row (integer only). Default set to 4.");
                    validRow = true;
                }


                Console.WriteLine("Enter the column number");
                string currentColumnString = Console.ReadLine();
                try 
                {
                    currentColumn = int.Parse(currentColumnString) - 1;
                    if (currentColumn >= 0 && currentColumn <= myBoard.Size - 3)
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
                    Console.WriteLine("Invalid input for column (integer only). Default set to 4.");
                    validColumn = true;
                }
            }

            myBoard.theGrid[currentRow, currentColumn].CurrentlyOccupied = true;
            return myBoard.theGrid[currentRow, currentColumn];
        }

        private static void printBoard(Board myBoard) 
        {
            // Top edge of board.
            Console.WriteLine("=================================");
            Console.WriteLine("+---+---+---+---+---+---+---+---+");

            // Print the chess board to the console (Note: X = piece, + = legal move, . = empty cell).
            for (int i = 0; i < myBoard.Size - 2; i++) 
            {
                for (int j = 0; j < myBoard.Size - 2; j++)
                {
                    Cell c = myBoard.theGrid[i, j];

                    if (c.CurrentlyOccupied == true) 
                    {
                        Console.Write("| X ");
                    } 
                    else if (c.LegalNextMove == true) 
                    {
                        Console.Write("| + ");
                    } 
                    else
                    {
                        Console.Write("|   ");
                    }
                }

                Console.Write("|");
                Console.WriteLine();
                Console.WriteLine("+---+---+---+---+---+---+---+---+");
            }

            // Bottom edge of board.
            Console.WriteLine("=================================");
        }
    }
}
