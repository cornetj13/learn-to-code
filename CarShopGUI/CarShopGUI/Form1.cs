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
            bool carNew = false;
            if (isNewTextBox.Text == "New" || isNewTextBox.Text == "new") 
            {
                carNew = true;
            }

            Car car = new Car(makeTextBox.Text, modelTextBox.Text, colorTextBox.Text, carNew, decimal.Parse(priceTextBox.Text));
            myStore.CarList.Add(car);
            carInventoryBindingSource.ResetBindings(false);
            makeTextBox.Clear();
            modelTextBox.Clear();
            colorTextBox.Clear();
            isNewTextBox.Clear();
            priceTextBox.Clear();
        }

        private void addToCartButton_Click(object sender, EventArgs e) 
        {

        }

        private void totalPriceButton_Click(object sender, EventArgs e) 
        {

        }

        private void Form1_Load(object sender, EventArgs e) 
        {
            carInventoryBindingSource.DataSource = myStore.CarList;
            carInventoryListBox.DataSource = carInventoryBindingSource;
            carInventoryListBox.DisplayMember = ToString();
        }
    }
}
