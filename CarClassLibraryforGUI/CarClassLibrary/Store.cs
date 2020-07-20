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

        // Method for getting total price of cars in the shopping list.
        public decimal Checkout()
        {
            // Initialize total cost.
            decimal totalCost = 0;

            // Add price of car in shopping list.
            foreach (var c in ShoppingList)
            {
                totalCost += c.Price;
            }

            // Clear shopping list to reset after checkout.
            ShoppingList.Clear();

            // Return cost of cars in shopping list.
            return totalCost;
        }
    }
}
