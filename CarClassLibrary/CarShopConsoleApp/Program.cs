using CarClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShopConsoleApp
{
    class Program 
    {
        static void Main(string[] args) 
        {
            Car c = new Car("Wayne Industries", "Batmobile", 1340000);
            Car d = new Car("Ford", "Mustang", 9200);

            Console.WriteLine("Car c is as follows: " + c.Make + " " + c.Model + " " + c.Price);
            Console.WriteLine("Car d is as follows: " + d.Make + " " + d.Model + " " + d.Price);

            Store myStore = new Store();

            myStore.ShoppingList.Add(c);
            myStore.ShoppingList.Add(d);

            decimal totalShoppingCost = myStore.Checkout();

            Console.WriteLine("The Shopping List Total is: " + totalShoppingCost);

            Console.ReadLine();
        }
    }
}
