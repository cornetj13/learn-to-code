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

            // Greet User.
            Console.WriteLine("Welcome to my car store! First, please create a car inventory.");
            Console.WriteLine("Next, choose the cars you want to buy from your inventory.");
            Console.WriteLine("Last, you can check out and see the total price you'll need to pay!");

            int action = chooseAction();

            while (action != 0) 
            {
                Console.WriteLine("You chose action " + action);
                action = chooseAction();
            }
            
            //Car c = new Car("Wayne Industries", "Batmobile", 1340000);
            //Car d = new Car("Ford", "Mustang", 9200);

            //Console.WriteLine("Car c is as follows: " + c.Make + " " + c.Model + " " + c.Price);
            //Console.WriteLine("Car d is as follows: " + d.Make + " " + d.Model + " " + d.Price);

            //Store myStore = new Store();

            //myStore.ShoppingList.Add(c);
            //myStore.ShoppingList.Add(d);

            //decimal totalShoppingCost = myStore.Checkout();

            //Console.WriteLine("The Shopping List Total is: " + totalShoppingCost);

            //Console.ReadLine();
        }

        static public int chooseAction()
        {
            int choice = 0;
            Console.WriteLine("Choose an action:");
            Console.WriteLine("Press 0 to quit.");
            Console.WriteLine("Press 1 to add a car to your inventory.");
            Console.WriteLine("Press 2 to add a car to your shopping list.");
            Console.WriteLine("Press 3 to checkout and see your total price.");

            try 
            {
                choice = int.Parse(Console.ReadLine());
            } 
            catch 
            {
                Console.WriteLine("Invalid action. Quitting Application.");
            }

            return choice;
        }
    }
}
