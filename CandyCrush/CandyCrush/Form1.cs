using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CandyCrush
{
    public partial class Form1 : Form 
    {

        private MyButton[,] buttonGrid;
        private Color currentColor, originalColor;
        private int rows, cols;

        public Form1() 
        {
            InitializeComponent();
            populateGrid();
        }

        public void populateGrid() 
        {
            int x, y = 0;

            // Calculate the number of rows and columns based on the size of the panel and button.
            cols = mainPanel.Height / MyButton.buttonSize;
            rows = mainPanel.Width / MyButton.buttonSize;

            // new 2D array of buttons.
            buttonGrid = new MyButton[rows, cols];

            // Populates the panel with a new button.
            for (int r = 0; r < rows; r++) 
            {
                for (int c = 0; c < cols; c++)
                {
                    buttonGrid[r, c] = new MyButton();
                    buttonGrid[r, c].row = r;
                    buttonGrid[r, c].col = c;

                    // Assign the same event handler to every button in the panel.
                    buttonGrid[r, c].Click += gridbutton_Click;

                    // Add the button to the panel.
                    mainPanel.Controls.Add(buttonGrid[r, c]);

                    // Change the location of the button to the appropriate spot.
                    buttonGrid[r, c].Location = new Point(r * MyButton.buttonSize, c * MyButton.buttonSize);
                }
            }
        }

        private void colorbutton_Click(object sender, EventArgs e) 
        {
            Button button = (Button) sender;
            currentColor = button.BackColor;
            pictureBox.BackColor = currentColor;
        }

        private void gridbutton_Click(object sender, EventArgs e)
        {
            MyButton button = (MyButton) sender;
            originalColor = button.BackColor;
            floddFill(button.row, button.col);
        }

        private void floddFill(int r, int c) 
        {
            buttonGrid[r, c].BackColor = currentColor;
        }
    }
}
