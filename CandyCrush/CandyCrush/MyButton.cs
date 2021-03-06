﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CandyCrush
{
    class MyButton : Button
    {
        public static Color[] myColors = { Color.Red, Color.Blue, Color.Green, Color.Yellow, Color.Orange, Color.Aqua, Color.Lime, Color.Fuchsia };

        static Random random = new Random();

        public static int buttonSize = 25;

        public int row { get; set; }
        public int col { get; set; }

        public MyButton() 
        {
            Width = Height = buttonSize;
            int initColor = random.Next() % myColors.Length;
            this.BackColor = myColors[initColor];
        }
    }
}
