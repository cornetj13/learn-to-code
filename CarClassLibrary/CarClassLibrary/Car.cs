using System;
using System.Collections.Generic;
using System.Text;

namespace CarClassLibrary 
{
    public class Car 
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public bool isNew { get; set; }
        public decimal Price { get; set; }

        public Car()
        {
            this.Make = "None";
            this.Model = "None";
            this.Color = "None";
            this.isNew = false;
            this.Price = 0.00M;
        }

        public Car(string mk, string md, string c, bool n, decimal p)
        {
            Make = mk;
            Model = md;
            Color = c;
            isNew = n;
            Price = p;
        }

        override public string ToString()
        {
            return "Make = " + Make + ", Model = " + Model + " Color = " + Color + " New = " + isNew + ", Price = $" + Price;
        }
    }
}
