using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnightsTour 
{
    class Program 
    {
        static int boardSize = 8;
        static int attemptedMoves = 0;

        static int[] xMove = {2, 2, -2, -2, 1, 1, -1, -1 };
        static int[] yMove = {1, -1, 1, -1, 2, -2, 2, -2 };

        static int[,] boardGrid = new int[boardSize, boardSize];

        static void Main(string[] args) 
        {
            solveKnightsTour();
            Console.ReadLine();
        }

        static void solveKnightsTour() 
        {
            // Intialize all squares to not visited.
            for (int i = 0; i < boardSize; i++) 
            {
                for (int j = 0; j < boardSize; j++) 
                {
                    // Set every point on board to -1 (which represents not visited).
                    boardGrid[i, j] = -1;
                }
            }

            // Initialize a starting point.
            int startX = 0;
            int startY = 0;
            boardGrid[startX, startY] = 0;
            attemptedMoves = 0;

            // Recursively try all possible legal moves. This will backtrack on dead end solutions.
            if (!solveKTUtil(startX, startY, 1)) 
            {
                Console.WriteLine("No solution found for {0}, {1}", startX, startY);
            } 
            else 
            {
                printBoard(boardGrid);
                Console.WriteLine("Total attempted moves: {0}.", attemptedMoves);
            }

            bool solveKTUtil(int x, int y, int moveCount) {
                // Update the user every 10 million moves.
                attemptedMoves++;
                if (attemptedMoves % 10000000 == 0) {
                    Console.WriteLine("Attempted {0} moves.", attemptedMoves);
                }

                // Counter for moving through the nextX and nextY arrays.
                int k;

                // Location for the next move in the recursion.
                int next_x, next_y;

                // Checks if the solution has been found.
                if (moveCount == boardSize * boardSize)
                    return true;

                // Cycle through all of the possible next moves for the Knight.
                for (k = 0; k < 8; k++) {
                    next_x = x + xMove[k];
                    next_y = y + yMove[k];
                    if (safeSquare(next_x, next_y)) {
                        boardGrid[next_x, next_y] = moveCount;
                        if (solveKTUtil(next_x, next_y, moveCount + 1))
                            return true;
                        else
                            boardGrid[next_x, next_y] = -1;
                    }
                }
                return false;
            }

            bool safeSquare(int x, int y) {
                // Check to see if x, y is on the board. Also, check to see if x, y has been visited yet.
                return (x >= 0 && x < boardSize && y >= 0 && y < boardSize && boardGrid[x, y] == -1);
            }

            void printBoard(int[,] boardToPrint) {
                for (int i = 0; i < boardSize; i++) {
                    for (int j = 0; j < boardSize; j++) {
                        if (boardGrid[i, j] < 10)
                            Console.Write(" ");
                        Console.Write(boardGrid[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
