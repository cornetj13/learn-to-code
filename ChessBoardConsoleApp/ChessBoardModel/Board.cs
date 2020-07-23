using System;
using System.Collections.Generic;
using System.Text;

namespace ChessBoardModel {
    public class Board {
        // Size of the board (usually 8x8).
        public int Size { get; set; }
        // 2D array of the grid (type Cell).
        public Cell[,] theGrid { get; set; }

        // Board constructor.
        public Board(int size) 
        {
            // Board size.
            Size = size + 2;

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
            switch (chessPiece) {
                case "Knight":
                    // Describes the L movement of the Knight, and checks if it's move is inbound.
                    if (Inbounds(currentCell.RowNumber + 2, currentCell.ColumnNumber + 1)) 
                    {
                        theGrid[currentCell.RowNumber + 2, currentCell.ColumnNumber + 1].LegalNextMove = true;
                    }
                    if (Inbounds(currentCell.RowNumber + 2, currentCell.ColumnNumber - 1)) 
                    {
                        theGrid[currentCell.RowNumber + 2, currentCell.ColumnNumber - 1].LegalNextMove = true;
                    }
                    if (Inbounds(currentCell.RowNumber - 2, currentCell.ColumnNumber + 1)) 
                    {
                        theGrid[currentCell.RowNumber - 2, currentCell.ColumnNumber + 1].LegalNextMove = true;
                    }
                    if (Inbounds(currentCell.RowNumber - 2, currentCell.ColumnNumber - 1)) 
                    {
                        theGrid[currentCell.RowNumber - 2, currentCell.ColumnNumber - 1].LegalNextMove = true;
                    }
                    if (Inbounds(currentCell.RowNumber + 1, currentCell.ColumnNumber + 2)) 
                    {
                        theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber + 2].LegalNextMove = true;
                    }
                    if (Inbounds(currentCell.RowNumber + 1, currentCell.ColumnNumber - 2)) 
                    {
                        theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber - 2].LegalNextMove = true;
                    }
                    if (Inbounds(currentCell.RowNumber - 1, currentCell.ColumnNumber + 2))
                    {
                        theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber + 2].LegalNextMove = true;
                    }
                    if (Inbounds(currentCell.RowNumber - 1, currentCell.ColumnNumber - 2)) 
                    {
                        theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber - 2].LegalNextMove = true;
                    }
                    break;

                case "King":
                    // Describes the single step movement of the King, and checks if it's move is inbound.
                    if (Inbounds(currentCell.RowNumber - 1, currentCell.ColumnNumber - 1))
                    {
                        theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber - 1].LegalNextMove = true;
                    }
                    if (Inbounds(currentCell.RowNumber - 1, currentCell.ColumnNumber)) 
                    {
                        theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber].LegalNextMove = true;
                    }
                    if (Inbounds(currentCell.RowNumber - 1, currentCell.ColumnNumber + 1))
                    {
                        theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber + 1].LegalNextMove = true;
                    }
                    if (Inbounds(currentCell.RowNumber, currentCell.ColumnNumber - 1)) 
                    {
                        theGrid[currentCell.RowNumber, currentCell.ColumnNumber - 1].LegalNextMove = true;
                    }
                    if (Inbounds(currentCell.RowNumber, currentCell.ColumnNumber + 1)) 
                    {
                        theGrid[currentCell.RowNumber, currentCell.ColumnNumber + 1].LegalNextMove = true;
                    }
                    if (Inbounds(currentCell.RowNumber + 1, currentCell.ColumnNumber - 1)) 
                    {
                        theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber - 1].LegalNextMove = true;
                    }
                    if (Inbounds(currentCell.RowNumber + 1, currentCell.ColumnNumber)) 
                    {
                        theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber].LegalNextMove = true;
                    }
                    if (Inbounds(currentCell.RowNumber + 1, currentCell.ColumnNumber + 1)) 
                    {
                        theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber + 1].LegalNextMove = true;
                    }
                    break;

                case "Rook":
                    // Describes the horizontal/vertical movement of the Rook, and checks if it's move is inbound.
                    for (int i = -Size; i < Size; i++) 
                    {
                        if (Inbounds(currentCell.RowNumber + i, currentCell.ColumnNumber)) 
                        {
                            theGrid[currentCell.RowNumber + i, currentCell.ColumnNumber].LegalNextMove = true;
                        }
                        if (Inbounds(currentCell.RowNumber, currentCell.ColumnNumber + i)) 
                        {
                            theGrid[currentCell.RowNumber, currentCell.ColumnNumber + i].LegalNextMove = true;
                        }
                    }
                    break;

                case "Bishop":
                    // Describes the diagonal movement of the Bishop, and checks if it's move is inbound.
                    for (int i = -Size; i < Size; i++) 
                    {
                        if (Inbounds(currentCell.RowNumber + i, currentCell.ColumnNumber + i)) 
                        {
                            theGrid[currentCell.RowNumber + i, currentCell.ColumnNumber + i].LegalNextMove = true;
                        }
                        if (Inbounds(currentCell.RowNumber - i, currentCell.ColumnNumber + i))
                        {
                            theGrid[currentCell.RowNumber - i, currentCell.ColumnNumber + i].LegalNextMove = true;
                        }
                    }
                    break;

                case "Queen":
                    // Describes the complex movement of the Queen, and checks if it's move is inbound.
                    for (int i = -Size; i < Size; i++) 
                    {
                        if (Inbounds(currentCell.RowNumber + i, currentCell.ColumnNumber)) 
                        {
                            theGrid[currentCell.RowNumber + i, currentCell.ColumnNumber].LegalNextMove = true;
                        }
                        if (Inbounds(currentCell.RowNumber, currentCell.ColumnNumber + i)) 
                        {
                            theGrid[currentCell.RowNumber, currentCell.ColumnNumber + i].LegalNextMove = true;
                        }
                        if (Inbounds(currentCell.RowNumber + i, currentCell.ColumnNumber + i)) 
                        {
                            theGrid[currentCell.RowNumber + i, currentCell.ColumnNumber + i].LegalNextMove = true;
                        }
                        if (Inbounds(currentCell.RowNumber - i, currentCell.ColumnNumber + i)) 
                        {
                            theGrid[currentCell.RowNumber - i, currentCell.ColumnNumber + i].LegalNextMove = true;
                        }
                    }
                    break;

                default:
                    Console.WriteLine("Invalid piece");
                    break;
            }

            // Show piece by setting currently occupied space (by piece) to true).
            theGrid[currentCell.RowNumber, currentCell.ColumnNumber].CurrentlyOccupied = true;

            // Step 3: Mark the appropriate cells as "Legal".
        }

        private bool Inbounds(int row, int col) 
        {
            if ((row < 0 || row > 8) || (col < 0 || col > 8))
            {
                return false;
            } 
            else 
            {
                return true;
            }
        }
    }
}
