using System;
using System.Collections.Generic;
using System.Text;

namespace ChessBoardModel
{
    public class Board 
    {
        // Size of the board (usually 8x8).
        public int Size { get; set; }
        // 2D array of the grid (type Cell).
        public Cell[,] theGrid { get; set; }

        // Board constructor.
        public Board(int size)
        {
            // Board size.
            Size = size;

            // Create a new 2D array (type Cell).
            theGrid = new Cell[Size, Size];

            // Fill the 2D array with new Cells, each with unique x and y coordinates.
            for (int i = 0; i < Size; i++) 
            {
                for (int j = 0; j < Size; j++) 
                {
                    theGrid[i, j] = new Cell(i, j);
                }
            }
        }

        public void MarkNextLegalMoves(Cell currentCell, string chessPiece) 
        {
            // Step 1: Clear all previous legal moves.
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    theGrid[i, j].LegalNextMove = false;
                    theGrid[i, j].CurrentlyOccupied = false;
                }
            }

            // Step 2: Find all legals moves.
            switch (chessPiece) 
            {
                case "Knight":
                    theGrid[currentCell.RowNumber + 2, currentCell.ColumnNumber + 1].LegalNextMove = true;
                    theGrid[currentCell.RowNumber + 2, currentCell.ColumnNumber - 1].LegalNextMove = true;
                    theGrid[currentCell.RowNumber - 2, currentCell.ColumnNumber + 1].LegalNextMove = true;
                    theGrid[currentCell.RowNumber - 2, currentCell.ColumnNumber - 1].LegalNextMove = true;
                    theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber + 2].LegalNextMove = true;
                    theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber - 2].LegalNextMove = true;
                    theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber + 2].LegalNextMove = true;
                    theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber - 2].LegalNextMove = true;
                    break;

                case "King":
                    break;

                case "Rook":
                    break;

                case "Bishop":
                    break;

                case "Queen":
                    break;
            }

            // Show piece by setting currently occupied space (by piece) to true).
            theGrid[currentCell.RowNumber, currentCell.ColumnNumber].CurrentlyOccupied = true;

            // Step 3: Mark the appropriate cells as "Legal".
        }
    }
}
