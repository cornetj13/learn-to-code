using System;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Text;

namespace MinesweeperModel 
{
    public class Board 
    {
        // Needed for random numbers.
        private static readonly RNGCryptoServiceProvider _generator = new RNGCryptoServiceProvider();

        // Size of the board.
        public int Size { get; set; }

        // 2D array of the grid (type Cell).
        public Cell[,] theGrid { get; set; }

        // Difficulty of game (decides percentage of bombs in game).
        public int Difficulty { get; set; }

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

        public void PlantBombs() 
        {
            // Plants bombs randomly on cells.
            for (int i = 0; i < Size; i++) 
            {
                int randomNumber = Between(0, 100);

                for (int j = 0; j < Size; j++) 
                {
                    randomNumber = Between(0, 100);

                    if (randomNumber > Difficulty) 
                    {
                        theGrid[i, j].ContainsBomb = false;
                    }
                    else if (randomNumber <= Difficulty)
                    {
                        theGrid[i, j].ContainsBomb = true;
                    }  
                }
            }
        }

        public int CalculateLiveNeighbors(int row, int col)
        {
            int liveCount = 0;

            if (Inbounds(row - 1, col - 1)) {
                liveCount += CheckIfLive(row - 1, col - 1);
            }

            if (Inbounds(row - 1, col)) {
                liveCount += CheckIfLive(row - 1, col);
            }

            if (Inbounds(row - 1, col + 1)) {
                liveCount += CheckIfLive(row - 1, col + 1);
            }

            if (Inbounds(row, col - 1)) {
                liveCount += CheckIfLive(row, col - 1);
            }

            if (Inbounds(row, col + 1)) {
                liveCount += CheckIfLive(row, col + 1);
            }

            if (Inbounds(row + 1, col - 1)) {
                liveCount += CheckIfLive(row + 1, col - 1);
            }

            if (Inbounds(row + 1, col)) {
                liveCount += CheckIfLive(row + 1, col);
            }

            if (Inbounds(row + 1, col + 1)) {
                liveCount += CheckIfLive(row + 1, col + 1);
            }

            return liveCount;

        }

        private int CheckIfLive(int row, int col)
        {
            if (theGrid[row, col].ContainsBomb == true) 
            {
                return 1;
            } 
            else
            {
                return 0;
            }
        }

        private bool Inbounds(int row, int col) 
        {
            if (row < 0 || row > Size - 1) 
            {
                return false;
            } 
            else if (col < 0 || col > Size - 1) 
            {
                return false;
            } 
            else 
            {
                return true;
            }
        }

        // Random number generator taken from https://scottlilly.com/create-better-random-numbers-in-c/#:~:text=Random%20class%2C%20and%20create%20new,and%20then%20stop%20the%20program.
        public static int Between(int minimumValue, int maximumValue) {
            byte[] randomNumber = new byte[1];

            _generator.GetBytes(randomNumber);

            double asciiValueOfRandomCharacter = Convert.ToDouble(randomNumber[0]);

            // We are using Math.Max, and substracting 0.00000000001, 
            // to ensure "multiplier" will always be between 0.0 and .99999999999
            // Otherwise, it's possible for it to be "1", which causes problems in our rounding.
            double multiplier = Math.Max(0, (asciiValueOfRandomCharacter / 255d) - 0.00000000001d);

            // We need to add one to the range, to allow for the rounding done with Math.Floor
            int range = maximumValue - minimumValue + 1;

            double randomValueInRange = Math.Floor(multiplier * range);

            return (int)(minimumValue + randomValueInRange);
        }
    }
}
