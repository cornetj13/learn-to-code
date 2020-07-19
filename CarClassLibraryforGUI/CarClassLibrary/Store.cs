using System;
using System.Collections.Generic;
using System.Text;

namespace CarClassLibrary {
    public class Store 
    {
        public List<Car> CarList { get; set; }
        public List<Car> ShoppingList { get; set; }

        public Store() 
        {
            CarList = new List<Car>();
            ShoppingList = new List<Car>();
        }

        // Method for Getting Total Price of Cars in Shopping List.
        public decimal Checkout()
        {
            // Initialize Total Cost.
            decimal totalCost = 0;

            // Add Price of Car in Shopping List.
            foreach (var c in ShoppingList)
            {
                totalCost += c.Price;
            }

            // Clear Shopping List to Reset after Checkout.
            ShoppingList.Clear();

            // Return Cost of Cars in Shopping List.
            return totalCost;
        }
    }
}
