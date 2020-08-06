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
        private int rows, cols, totalButtons;
        private int turns = 40;
        private int changedButtons = 0;

        public static Color[] myColors = { Color.Red, Color.Blue, Color.Green, Color.Yellow, Color.Orange, Color.Aqua, Color.Lime, Color.Fuchsia };

        static Random random = new Random();

        public Form1() 
        {
            InitializeComponent();
            populateGrid();
        }

        public void populateGrid() 
        {
            // Reset turns.
            turns = 40;
            changedButtons = 0;

            // Calculate the number of rows and columns based on the size of the panel and button.
            cols = mainPanel.Height / MyButton.buttonSize;
            rows = mainPanel.Width / MyButton.buttonSize;
            totalButtons = cols * rows;

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

            // Display turns.
            clicksLeftLabel.Text = turns.ToString();
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
            floodFill(button.row, button.col);

            // Calculate and display turns.
            if (currentColor != originalColor) 
            {
                turns = turns - 1;
                changedButtons = changedButtons + 1;
                clicksLeftLabel.Text = turns.ToString();
            }

            // Check if player has won and if so, display winninging message.
            int similarButtons = 0;
            bool isWinning = false;
            for (int i = 0; i < rows; i++) {
                for (int j = 0; j < cols; j++) {
                    if (buttonGrid[i, j].BackColor == currentColor)
                    {
                        similarButtons++;
                    }
                }
            }
            if (similarButtons == totalButtons)
            {
                isWinning = true;
                MessageBox.Show("You Win!!");
                mainPanel.Controls.Clear();
                turns = 40;
                changedButtons = 0;
                populateGrid();
            }

            // Check if player has lost and if so, display losing message.
            if (turns == 0 && isWinning == false) 
            {
                MessageBox.Show("Sorry, you lose!");
                mainPanel.Controls.Clear();
                turns = 40;
                changedButtons = 0;
                populateGrid();
            }

            // Add random color change.
            for (int i = 0; i < changedButtons % 4; i++) 
            {
                if (turns > 8)
                {
                    int x = random.Next() % rows;
                    int y = random.Next() % cols;

                    int randomColor = random.Next() % myColors.Length; ;
                    buttonGrid[x, y].BackColor = myColors[randomColor];
                }
            }
        }

        private void resetButton_Click(object sender, EventArgs e) 
        {
            mainPanel.Controls.Clear();
            turns = 40;
            changedButtons = 0;
            populateGrid();
        }

        private void floodFill(int r, int c) 
        {
            if (isValid(r, c) && buttonGrid[r, c].BackColor.Equals(originalColor) && buttonGrid[r, c].BackColor != currentColor)
            {
                // Change the current cell clicked.
                buttonGrid[r, c].BackColor = currentColor;

                // Apply to the cell to the right (r + 1), the left (r - 1), below (c + 1), and above (c - 1).
                floodFill(r + 1, c);
                floodFill(r - 1, c);
                floodFill(r, c + 1);
                floodFill(r, c - 1);
            }
        }

        private bool isValid(int r, int c)
        {
            if (r < 0 || r >= rows || c < 0 || c >= cols)
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
