using ChessBoardModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessBoardGUIApp {
    public partial class Form1 : Form 
    {
        // Reference to the Board class. Contains the values of the Board.
        static Board myBoard = new Board(8);

        // 2D array of buttons whose values are determined by myBoard.
        public Button[,] buttonGrid = new Button[myBoard.Size, myBoard.Size];

        public Form1() 
        {
            InitializeComponent();
            populateGrid();
        }

        // Creates buttons and places them into the button panel.
        private void populateGrid() 
        {
            // Calculate appropriate button size.
            int buttonSize = buttonPanel.Width / myBoard.Size;

            // Ensure buttons are square.
            buttonPanel.Height = buttonPanel.Width;

            // Nested loop for creating buttons and printing them to the form.
            for (int i = 0; i < myBoard.Size; i++)
            {
                for (int j = 0; j < myBoard.Size; j++) 
                {
                    buttonGrid[i, j] = new Button();

                    buttonGrid[i, j].Height = buttonSize;
                    buttonGrid[i, j].Width = buttonSize;

                    // Add a click event to each button.
                    buttonGrid[i, j].Click += GridButtonClick;

                    // Place buttons into panel.
                    buttonPanel.Controls.Add(buttonGrid[i, j]);

                    // Set location of the new button.
                    buttonGrid[i, j].Location = new Point(i * buttonSize, j * buttonSize);

                    // Saves button location to memory (using Tag).
                    buttonGrid[i, j].Tag = new Point(i, j);
                }
            }
        }

        private void GridButtonClick(object sender, EventArgs e)
        {   
            // Get piece information when button clicked.
            string pieceSelected = selectedPieceComboBox.Text;
            
            // Gets the row and column number of the button clicked.
            Button clickButton = (Button) sender;
            Point location = (Point) clickButton.Tag;

            int x = location.X;
            int y = location.Y;

            Cell currentCell = myBoard.theGrid[x, y];

            // Determine the legal moves for the piece.
            myBoard.MarkNextLegalMoves(currentCell, pieceSelected);

            // Update the text on each button.
            for (int i = 0; i < myBoard.Size; i++) 
            {
                for (int j = 0; j < myBoard.Size; j++) 
                {
                    // Clears previous click.
                    buttonGrid[i, j].Text = "";
                    buttonGrid[i, j].BackColor = Color.Transparent;

                    // Writes piece name and legal moves.
                    if (myBoard.theGrid[i, j].LegalNextMove == true) 
                    {
                        buttonGrid[i, j].Text = "Legal";
                    } 
                    if (myBoard.theGrid[i, j].CurrentlyOccupied == true) 
                    {
                        buttonGrid[i, j].Text = pieceSelected;

                        // Change button color.
                        clickButton.BackColor = Color.Cornsilk;
                    }
                }
            }
        }
    }
}
