using System;
using System.Collections.Generic;
using System.Text;

namespace MinesweeperModel 
{
    public class Board 
    {
        // Size of the board.
        public int Size { get; set; }

        // 2D array of the grid (type Cell).
        public Cell[,] theGrid { get; set; }

        // Board constructor.
        public Board(int size) {
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
    }
}
