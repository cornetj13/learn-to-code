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

            // Calcualte all legal moves for the piece.
            myBoard.MarkNextLegalMoves(currentCell, "Knight");

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
            int currentRow = 4;
            int currentColumn = 4;

            // Ask user for x and y coordinates. Return a cell location.
            Console.WriteLine("Enter the row number");
            string currentRowString = Console.ReadLine();
            try 
            {
                currentRow = int.Parse(currentRowString);
            } 
            catch 
            {
                Console.WriteLine("Invalid row number. Defaults to 4.");
            }

            
            Console.WriteLine("Enter the column number");
            string currentColumnString = Console.ReadLine();
            try 
            {
                currentColumn = int.Parse(currentColumnString);
            } 
            catch 
            {
                Console.WriteLine("Invalid Column number. Defaults to 4.");
            }

            myBoard.theGrid[currentRow, currentColumn].CurrentlyOccupied = true;
            return myBoard.theGrid[currentRow, currentColumn];
        }

        private static void printBoard(Board myBoard) 
        {
            // Top edge of board.
            Console.WriteLine("========");

            // Print the chess board to the console (Note: X = piece, + = legal move, . = empty cell).
            for (int i = 0; i < myBoard.Size; i++) 
            {
                for (int j = 0; j < myBoard.Size; j++)
                {
                    Cell c = myBoard.theGrid[i, j];

                    if (c.CurrentlyOccupied == true) 
                    {
                        Console.Write("X");
                    } 
                    else if (c.LegalNextMove == true) 
                    {
                        Console.Write("+");
                    } 
                    else
                    {
                        Console.Write(".");
                    }
                }

                Console.WriteLine();
            }

            // Bottom edge of board.
            Console.WriteLine("========");
        }
    }
}
