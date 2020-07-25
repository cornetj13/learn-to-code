using System;
using System.Collections.Generic;
using System.Text;

namespace MinesweeperModel 
{
    public class Cell 
    {
        public int RowNumber { get; set; }
        public int ColumnNumber { get; set; }
        public int LiveNeighbors { get; set; }
        public bool Visited { get; set; }
        public bool ContainsBomb { get; set; }

        public Cell(int x, int y) 
        {
            RowNumber = x;
            ColumnNumber = y;
        }
    }
}
