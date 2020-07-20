using CarClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarShopGUI {
    public partial class Form1 : Form 
    {

        Store myStore = new Store();
        BindingSource carInventoryBindingSource = new BindingSource();
        BindingSource shoppingListBindingSource = new BindingSource();

        public Form1() 
        {
            InitializeComponent();
        }

        private void createCarButton_Click(object sender, EventArgs e) 
        {
            // Translates user input into appropriate boolean.
            bool carNew = false;
            if (isNewTextBox.Text == "New" || isNewTextBox.Text == "new") 
            {
                carNew = true;
            }

            // Adds car to car inventory.
            Car car = new Car(makeTextBox.Text, modelTextBox.Text, colorTextBox.Text, carNew, decimal.Parse(priceTextBox.Text));
            myStore.CarList.Add(car);
            carInventoryBindingSource.ResetBindings(false);

            // Clears input boxes.
            makeTextBox.Clear();
            modelTextBox.Clear();
            colorTextBox.Clear();
            isNewTextBox.Clear();
            priceTextBox.Clear();
        }

        private void addToCartButton_Click(object sender, EventArgs e) 
        {
            // Get selected item from the inventory.
            Car selectedCar = (Car) carInventoryListBox.SelectedItem;

            // Add item to shopping list.
            myStore.ShoppingList.Add(selectedCar);

            // Update the list box control.
            shoppingListBindingSource.ResetBindings(false);  
        }

        private void totalPriceButton_Click(object sender, EventArgs e) 
        {
            // Calculate total price.
            decimal totalPrice = myStore.Checkout();
            totalDisplayLabel.Text = "$" + totalPrice.ToString();

            // Clears shopping list after checkout.
            shoppingListBindingSource.ResetBindings(false);
        }

        private void Form1_Load(object sender, EventArgs e) 
        {
            // Set binding source to correct lists from myStore.
            carInventoryBindingSource.DataSource = myStore.CarList;
            shoppingListBindingSource.DataSource = myStore.ShoppingList;

            // Bind list boxes to correct binding sources.
            carInventoryListBox.DataSource = carInventoryBindingSource;
            carInventoryListBox.DisplayMember = ToString();
            shoppingCartListBox.DataSource = shoppingListBindingSource;
            shoppingCartListBox.DisplayMember = ToString();
        }
    }
}
